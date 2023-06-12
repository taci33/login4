using login4.Models;
using login4.Models.EF;
using login4.Services.EmailService;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.WebUtilities;
using MimeKit;
using System.ComponentModel.DataAnnotations;
using System.Net;
using System.Text.Encodings.Web;
using System.Text;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace login4.Pages.GestionUsuarios
{
    public class RegistrarClienteModel : PageModel
    {
        private readonly UserManager<IdentityUser> _userManager;
        private IntranetSenasaData230209Context _context;
        private readonly IUserStore<IdentityUser> _userStore;
        private readonly IUserEmailStore<IdentityUser> _emailStore;
        private readonly IEmailService _emailService;
        private readonly IWebHostEnvironment _env;

        public RegistrarClienteModel(UserManager<IdentityUser> userManager,
              IUserStore<IdentityUser> userStore,
            IntranetSenasaData230209Context context,
            IEmailService emailService,
            IWebHostEnvironment env)
        {

            _emailService = emailService;
            _userManager = userManager;
            _context = context;
            _userStore = userStore;
            _emailStore = GetEmailStore();
            _env = env;
        }
        [BindProperty]
        public InputModel Input { get; set; }
        public class InputModel
        {
            [Required]
            public string Nombre { get; set; }
            public string IDpersona { get; set; }

            public string RolAcceso { get; set; }

            [Required]
            [EmailAddress]
            [Display(Name = "Email")]
            public string Email { get; set; }

        }

        public void OnGet()
        {
        }


        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            
            returnUrl ??= Url.Content("~/");

            if (await _userManager.FindByEmailAsync(Input.Email) == null)
            {
                try
                {
                    var user = new appusuario
                    {
                    Nombre = Input.Nombre,
                    IDpersona = Input.IDpersona,
                    RolAcceso = "Cliente"

                    };

            var password = GenerateRandomPassword();
            await _userStore.SetUserNameAsync(user, Input.Email, CancellationToken.None);
            await _emailStore.SetEmailAsync(user, Input.Email, CancellationToken.None);
            var result = await _userManager.CreateAsync(user, password);
                    if (result.Succeeded)
                    {
                        var userId = await _userManager.GetUserIdAsync(user);
                        var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                        await _userManager.AddToRoleAsync(user, "Cliente");
                        //var confirmacion = await _userManager.ConfirmEmailAsync(user, code);//confirmo temporalmente el email tal cual se registran
                        var lockDisabledTask = _userManager.SetLockoutEnabledAsync(user, false);
                        lockDisabledTask.Wait();
                        //code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
                        // Enviar la confirmacion por correo electrónico

                        var callbackUrl = Url.Page(
                      "/Account/ConfirmEmail",
                      pageHandler: null,
                      values: new { area = "Identity", userId = userId, code = code, returnUrl = returnUrl },
                      protocol: Request.Scheme);

                        // Crea una instancia de la clase UrlPlantilla, pasando el parámetro IWebHostEnvironment env en el constructor
                        var urlPlantilla = new UrlPlantilla(_env);
                        var templateUrl = urlPlantilla.UrlTemplate("mt_registro.html"); // Llama al método UrlTemplate, pasando el parámetro templatename



                        var name = ((appusuario)user).Nombre;
                        var link = HtmlEncoder.Default.Encode(callbackUrl);

                        var builder = new BodyBuilder();

                        using (StreamReader SourceReader = System.IO.File.OpenText(templateUrl))//carga la plantilla
                        {

                            builder.HtmlBody = SourceReader.ReadToEnd();
                        }
                        //sustituye los campos de la plantilla por los valores deseados
                        builder.HtmlBody = builder.HtmlBody.Replace("{{link}}", link);
                        builder.HtmlBody = builder.HtmlBody.Replace("{{nombre}}", name);
                        builder.HtmlBody = builder.HtmlBody.Replace("{{email}}", Input.Email);
                        var replybody = builder.HtmlBody;

                        var mail = new EmailDto
                        {
                            To = /*email*/"aalbertosanzcarmen@gmail.com",
                            Subject = "prueba",
                            Body = replybody
                        };

                        _emailService.SendEmail(mail);
                        GuardarEmail(Input.Email, int.Parse(Input.IDpersona));
                    }

                    else
                    {
                        foreach (var error in result.Errors)
                        {
                            ModelState.AddModelError(string.Empty, error.Description);
                        }

                    }
                    Response.StatusCode = (int)HttpStatusCode.OK;
                    return LocalRedirect(returnUrl);
                    //return Page();
                }
                catch (Exception ex)
                {
                    // Manejar la excepción adecuadamente
                    ModelState.AddModelError("", ex.Message);
                    // Devuelve una respuesta con el mensaje de error al cliente
                    return Page();
                }
            }
            else
                return Page();




        }


        [HttpPost]
        private void GuardarEmail(string email, int IDPersona)
        {
            try
            {
                var ext_email = new SqlParameter("@EXT_Email", SqlDbType.VarChar, 250);
                ext_email.Value = email;
                var idpersona = new SqlParameter("@IDPersona", SqlDbType.Int);
                idpersona.Value = IDPersona;
                _context.Database.ExecuteSqlRaw("EXECUTE EXT_adm_CL_Email_Update @IDPersona, @EXT_Email", idpersona, ext_email);

            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
            }
        }

        
        private string GenerateRandomPassword()
        {
            // utilizo un string para cada tipo de caracter con la intencion de que siempre cumpla con el minimo
            var minus = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            var numeros = "1234567890";
            var especiales = ",._/*+-@#";
            var random = new Random();
            var letras = new string(Enumerable.Repeat(minus, 8)
                  .Select(s => s[random.Next(s.Length)]).ToArray());
            var num = new string(Enumerable.Repeat(numeros, 4)
                    .Select(s => s[random.Next(s.Length)]).ToArray());
            var esp = new string(Enumerable.Repeat(especiales, 2)
                    .Select(s => s[random.Next(s.Length)]).ToArray());
            var password = letras + num + esp;

            return password;
        }
        private IUserEmailStore<IdentityUser> GetEmailStore()
        {
            if (!_userManager.SupportsUserEmail)
            {
                throw new NotSupportedException("The default UI requires a user store with email support.");
            }
            return (IUserEmailStore<IdentityUser>)_userStore;
        }
    }

}
