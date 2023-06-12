using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using login4.Models.EF;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Net.Mail;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.JSInterop;
using Microsoft.AspNetCore.WebUtilities;
using System.Text;
using Microsoft.VisualBasic;
using System.Net;
using System.Drawing.Text;
using System.Data;
using System.Xml.Linq;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using static NuGet.Packaging.PackagingConstants;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Data.SqlClient;
using login4.Models;
using MimeKit;
using System.Text.Encodings.Web;
using login4.Services.EmailService;
using login4.Pages.GestionUsuarios;

namespace login4.Controllers

{
    [Route("api/[controller]/[action]")]
    public class ClientesSinRegistrarController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private IntranetSenasaData230209Context _context;
        private readonly IUserStore<IdentityUser> _userStore;
        private readonly IUserEmailStore<IdentityUser> _emailStore;
        private readonly IEmailService _emailService;
        private readonly IWebHostEnvironment _env;

        public ClientesSinRegistrarController(UserManager<IdentityUser> userManager,
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

        [HttpGet]
        public IActionResult Get(DataSourceLoadOptions loadOptions)
        {
            {
                var clientIdParameter = new SqlParameter("@IDTipo", SqlDbType.Int);
                clientIdParameter.Value = DBNull.Value;
                var clientIdParameter2 = new SqlParameter("@LockoutEnabled", false);
                var clientIdParameter3 = new SqlParameter("@UsuarioRegistrado", false);
                var clientIdParameter4 = new SqlParameter("@EmailConfirmed", false);
                var clientes = _context.ext_adm_CL_Searchs
                .FromSqlRaw("exec ext_adm_CL_Search @IDTipo,@LockoutEnabled,@UsuarioRegistrado,@EmailConfirmed", clientIdParameter, clientIdParameter2, clientIdParameter3, clientIdParameter4)
                .AsEnumerable().Select(i => new
                {
                    i.IDPersona,
                    i.Nombre,
                    i.NombreComercial,
                    i.Telefono,
                    i.Fax,
                    i.CIF_NIF,
                    i.Email,
                    i.PaginaWeb,
                    i.UsuarioRegistrado,
                    i.TipoDeCliente,
                    i.TipoID,
                    i.LockoutEnabled
                 

                })
                .ToList();

                return Json(DataSourceLoader.Load(clientes, loadOptions));
            }

        }
        [HttpPost]
        public async Task<IActionResult> Registrar(string email, string nombre, string idpersona)
        {

            string returnUrl = null;
            returnUrl ??= Url.Content("~/");

            if (await _userManager.FindByEmailAsync(email) == null)
            {
                try
                {
                    //Generar una contraseña aleatoria
                    var password = GenerateRandomPassword();
                    // crea un user para introducir los datos que no tiene identity por defecto

                    var user = new appusuario
                    {
                        Nombre = nombre,
                        IDpersona = idpersona,
                        RolAcceso = "Usuario"
                    };
                    await _userStore.SetUserNameAsync(user, email, CancellationToken.None);
                    await _emailStore.SetEmailAsync(user, email, CancellationToken.None);
                    var result = await _userManager.CreateAsync(user, password);

                    if (result.Succeeded)
                    {
                        var userId = await _userManager.GetUserIdAsync(user);
                        var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                        await _userManager.AddToRoleAsync(user, "Usuario");
                        //var confirmacion = await _userManager.ConfirmEmailAsync(user, code);//confirmo temporalmente el email tal cual se registran
                        var lockDisabledTask = _userManager.SetLockoutEnabledAsync(user, false);
                        lockDisabledTask.Wait();
                       
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
                        builder.HtmlBody = builder.HtmlBody.Replace("{{email}}", email);
                        var replybody = builder.HtmlBody;

                        var mail = new EmailDto
                        {
                            To = /*email*/"aalbertosanzcarmen@gmail.com", //tambien habra que cambiarlo en /gestionUsuarios/Registrarcliente.cs
                            Subject = "prueba",
                            Body = replybody
                        };

                        _emailService.SendEmail(mail);
                        GuardarEmail(email, int.Parse(idpersona));
                    }

                    else
                    {
                        foreach (var error in result.Errors)
                        {
                            ModelState.AddModelError(string.Empty, error.Description);
                        }

                    }
                    Response.StatusCode = (int)HttpStatusCode.OK;
                    return Json("Registro exitoso: ");
                }
                catch (Exception ex)
                {
                    // Manejar la excepción adecuadamente
                    ModelState.AddModelError("", ex.Message);
                    // Devuelve una respuesta con el mensaje de error al cliente
                    return View();
                }
            }
            else
                return Json("El usuario ya estaba registrado");

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
                
            }catch (Exception ex)
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


        [HttpGet]
        public object GetTipo(DataSourceLoadOptions loadOptions)
        {
            
                //var clientIdParameter = new SqlParameter("@IDTipo", SqlDbType.Int);
                //clientIdParameter.Value = DBNull.Value;
                //var clientIdParameter2 = new SqlParameter("@LockoutEnabled", false);
                var clientes = _context.EXT_adm_CL_Tipos_lookups
                .FromSqlRaw("exec EXT_adm_CL_Tipos_lookup")
                .AsEnumerable().Select(i => new
                {
                    i.IDTipo,
                    i.Nombre
                })
                .ToList();                //.ToListAsync();

                //var clientes = _context.ext_adm_CL_Searchs.Select(i => new { i.IDPersona, i.Nombre });

                return Json(DataSourceLoader.Load(clientes, loadOptions));
            }

            [HttpGet]
            public object GetEmail(int IDPersona, DataSourceLoadOptions loadOptions)
            {

            try
            {
                var IDpersona = new SqlParameter("@IDPersona", SqlDbType.Int);
                IDpersona.Value = IDPersona;
                var clientes = _context.EXT_adm_CL_email_lookups
                    .FromSqlRaw("exec EXT_adm_CL_email_lookup @IDPersona", IDpersona)
                    .AsEnumerable().Select(i => new
                    {

                        i.IDContacto,
                        i.Email,
                        i.Descripcion
                    })
                    .ToList();                //.ToListAsync();

                //var clientes = _context.ext_adm_CL_Searchs.Select(i => new { i.IDPersona, i.Nombre });

                return Json(DataSourceLoader.Load(clientes, loadOptions));

            }catch (Exception ex) {
                ModelState.AddModelError("", ex.Message);
                 


                // Devuelve una respuesta con el mensaje de error al cliente
                return View();
            }
            }
        private IUserEmailStore<IdentityUser> GetEmailStore()
        {
            if (!_userManager.SupportsUserEmail)
            {
                throw new NotSupportedException("The default UI requires a user store with email support.");
            }
            return (IUserEmailStore<IdentityUser>)_userStore;
        }

       
        //private string GetFullErrorMessage(ModelStateDictionary modelState)
        //{
        //    var messages = new List<string>();

        //    foreach (var entry in modelState)
        //    {
        //        foreach (var error in entry.Value.Errors)
        //            messages.Add(error.ErrorMessage);
        //    }

        //    return String.Join(" ", messages);
        //}


    }
}


