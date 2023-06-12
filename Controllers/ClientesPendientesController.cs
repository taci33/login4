using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using login4.Models;
using login4.Models.EF;
using login4.Pages.GestionUsuarios;
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

        //el metodo get carga los datos del procedimiento almacenado

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
                    i.EmailConfirmed,
                    i.EXT_Email
                    

                })
                .ToList();


                return Json(DataSourceLoader.Load(clientes, loadOptions));
            }
        }

        //metodo que proporciona los datos al lookup de filtrado por IDTipo
        [HttpGet]
        public object GetTipo(DataSourceLoadOptions loadOptions)
        {

           
            var clientes = _context.EXT_adm_CL_Tipos_lookups
            .FromSqlRaw("exec EXT_adm_CL_Tipos_lookup")
            .AsEnumerable().Select(i => new
            {
                i.IDTipo,
                i.Nombre
            })
            .ToList();               

            return Json(DataSourceLoader.Load(clientes, loadOptions));
        }


        //este metodo le proporciona la lista de emails asociados a cada cliente para seleccionar el email con el que sera registrado en la extranet
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
                    .ToList();                

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
                
                var callbackUrl = Url.Page(
              "/Account/ConfirmEmail",
              pageHandler: null,
              values: new { area = "Identity", userId = userId, code = code, returnUrl = returnUrl },
              protocol: Request.Scheme);

               
                var templatename = "mt_registro.html";
                var urlPlantilla = new UrlPlantilla(_env);
                var templateUrl = urlPlantilla.UrlTemplate(templatename); // creo la url completa de la platilla


                var name = ((appusuario)user).Nombre;
                var link = HtmlEncoder.Default.Encode(callbackUrl); //creo el link de confirmacion
            
                var builder = new BodyBuilder();
          
                using (StreamReader SourceReader = System.IO.File.OpenText(templateUrl))
                {

                    builder.HtmlBody = SourceReader.ReadToEnd();//leo la plantilla completa
                }
                //reemplazamos los campos en la plantilla
                builder.HtmlBody = builder.HtmlBody.Replace("{{link}}", link);
                builder.HtmlBody = builder.HtmlBody.Replace("{{nombre}}", name);
                builder.HtmlBody = builder.HtmlBody.Replace("{{email}}", email);
                var replybody = builder.HtmlBody;
               
                //creamos el objeto con el contenido del email
                var mail = new EmailDto
                {
                    To = /*email*/"aalbertosanzcarmen@gmail.com",
                    Subject = "Registro",
                    Body = replybody
                };

                _emailService.SendEmail(mail);
                
                return Ok("Email reenviado correctamente.");
            }
            else
                return Json("ERROR");



        }

        [HttpPost]
        public async Task<IActionResult> Desregistrar(string email)
        {
            // Buscar el usuario por el email
            var user = await _userManager.FindByEmailAsync(email);
            if (user == null)
            {
                // Manejar el escenario donde el usuario no se encuentra
                return NotFound();
            }

            try
            {
                // Eliminar los datos del usuario en las tablas de Identity
                var result = await _userManager.DeleteAsync(user);
                if (!result.Succeeded)
                {
                    // Manejar el escenario donde ocurre un error durante la eliminación
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }
                    return BadRequest(ModelState);
                }

                // Realizar otras operaciones para eliminar los datos relacionados al usuario en otras tablas

                // Manejar el escenario de éxito
                return Ok("Datos de usuario eliminados correctamente");
            }
            catch (Exception ex)
            {
                // Manejar la excepción adecuadamente
                ModelState.AddModelError("", ex.Message);
                // Devolver una respuesta con el mensaje de error al cliente
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }







    }
}

