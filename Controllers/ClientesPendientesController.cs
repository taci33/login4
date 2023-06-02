using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using login4.Models;
using login4.Models.EF;
using login4.Pages;
using login4.Services.EmailService;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using MimeKit;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.Encodings.Web;

namespace login4.Controllers
{
    [Route("api/[controller]/[action]")]
    public class ClientesPendientesController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private IntranetSenasaData230209Context _context;
        private readonly IEmailService _emailService;
        private readonly IWebHostEnvironment _env;
        public ClientesPendientesController(UserManager<IdentityUser> userManager, IntranetSenasaData230209Context context, IWebHostEnvironment env, IEmailService emailService)
        {
            _userManager = userManager;
            _context = context;
            _emailService = emailService;
            _env = env;
        }

        [HttpGet]
        public IActionResult Get(DataSourceLoadOptions loadOptions)
        {
            {
                var clientIdParameter = new SqlParameter("@IDTipo", SqlDbType.Int);
                clientIdParameter.Value = DBNull.Value;
                var clientIdParameter2 = new SqlParameter("@LockoutEnabled", false);
                var clientIdParameter3 = new SqlParameter("@UsuarioRegistrado", true);
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
                    i.LockoutEnabled,
                    i.EmailConfirmed

                })
                .ToList();


                //var clientes = _context.ext_adm_CL_Searchs.Select(i => new { i.IDPersona, i.Nombre });

                return Json(DataSourceLoader.Load(clientes, loadOptions));
            }
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

            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);



                // Devuelve una respuesta con el mensaje de error al cliente
                return View();
            }
        }
        [HttpPost]
        public async Task<IActionResult> Reenviar(string email)
        {
            string returnUrl = null;
            returnUrl ??= Url.Content("~/");
            // Obtener el usuario correspondiente al userId
            var user = await _userManager.FindByEmailAsync(email);

            if (!user.EmailConfirmed)
            {
                var userId = await _userManager.GetUserIdAsync(user);
                var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                //var confirmacion = await _userManager.ConfirmEmailAsync(user, code);//confirmo temporalmente el email tal cual se registran
                code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
                // Enviar la contraseña por correo electrónico

                //var confirmationLink = Url.Action(nameof(ConfirmEmail()), "Pages", new { code, email = user.Email }, Request.Scheme);
                //var message = new Message(new string[] { user.Email }, "Confirmation email link", confirmationLink, null);
                //await _emailSender.SendEmailAsync(message);

                //var callbackUrl = Url.Page(
                //"/GestionUsuarios/ConfirmarEmail",
                //pageHandler: null,
                //values: new { area = "Pages", userId = userId, code = code, returnUrl = returnUrl },
                //protocol: Request.Scheme);
                var callbackUrl = Url.Page(
              "/Account/ConfirmEmail",
              pageHandler: null,
              values: new { area = "Identity", userId = userId, code = code, returnUrl = returnUrl },
              protocol: Request.Scheme);

                var rootPath = _env.WebRootPath;
                var templatename = "mt_registro.html";
                var templateUrl = rootPath + "\\mail_templates\\" + templatename;

                var name = ((appusuario)user).Nombre;
                var link = HtmlEncoder.Default.Encode(callbackUrl);
                //var webRoot = _env.WebRootPath;
                var builder = new BodyBuilder();
                //using(StreamReader SourceReader = System.IO.File.OpenText("C:\\Users\\Practicas\\source\\repos\\taci33\\login4\\wwwroot\\mail_templates\\mt_registro.html"))
                using (StreamReader SourceReader = System.IO.File.OpenText(templateUrl))
                {

                    builder.HtmlBody = SourceReader.ReadToEnd();
                }

                builder.HtmlBody = builder.HtmlBody.Replace("{{link}}", link);
                builder.HtmlBody = builder.HtmlBody.Replace("{{nombre}}", name);
                builder.HtmlBody = builder.HtmlBody.Replace("{{email}}", email);
                var replybody = builder.HtmlBody;
                //var cuerpo = "su correo " + email + " ha sido registrado. Introduzca su nueva contraseña a traves del siguiente link:" +
                //    $" <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>Pulse aquí</a>.";

                //var cuerpo = "su correo " + email + " ha sido registrado en la intranet con contraseña: " + password + "  " + confirmationLink;
                var mail = new EmailDto
                {
                    To = /*email*/"aalbertosanzcarmen@gmail.com",
                    Subject = "prueba",
                    Body = replybody
                };

                _emailService.SendEmail(mail);
                //return RedirectToAction(nameof(SuccessRegistration));
                return Ok("Email reenviado correctamente.");
            }
            else
                return Json("ERROR");



        }

         
        






    }
}

