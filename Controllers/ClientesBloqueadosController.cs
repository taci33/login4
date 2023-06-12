using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using login4.Models.EF;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Caching.Memory;
using System.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.WebUtilities;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using static NuGet.Packaging.PackagingConstants;
using login4.Services.EmailService;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System.Net;
using login4.Pages.GestionUsuarios;

namespace login4.Controllers
{
    [Route("api/[controller]/[action]")]
    public class ClientesBloqueadosController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private IntranetSenasaData230209Context _context;
        public ClientesBloqueadosController(
           UserManager<IdentityUser> userManager, IntranetSenasaData230209Context context)
        {
            
            _userManager = userManager;
           _context = context;
        }

        

        [HttpGet]
        public IActionResult Get(DataSourceLoadOptions loadOptions)
        {
            {
                var clientIdParameter = new SqlParameter("@IDTipo", SqlDbType.Int);
                clientIdParameter.Value = DBNull.Value;
                var clientIdParameter2 = new SqlParameter("@LockoutEnabled", true);
                var clientIdParameter3 = new SqlParameter("@UsuarioRegistrado", true);
                var clientIdParameter4 = new SqlParameter("@EmailConfirmed", true);
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
                    i.EXT_Email

                })
                .ToList();


                //var clientes = _context.ext_adm_CL_Searchs.Select(i => new { i.IDPersona, i.Nombre });

                return Json(DataSourceLoader.Load(clientes, loadOptions));
            }
        }
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

        [HttpGet]
        public object GetEmail(int IDPersona, DataSourceLoadOptions loadOptions)
        {
            //consulta la lista de emails de cada IDPersona
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
        [HttpPost]
        public async Task<IActionResult> Bloquear(string email)
        {
            //para poder bloquear usuarios temporalmente recurrimos al lockoutenabled, con esta funcion podemos bloquear a los usuarios durante un tiempo concreto
            //en este caso como se trata de un bloqueo indefinido se le bloqueara durante años, si se vuelve a llamar a este metodo se debloqueara el user
            var user = await _userManager.FindByEmailAsync(email);

            if (!user.LockoutEnabled)
            {
                var EndDate = new DateTime(2222, 06, 06);
                var lockUserTask = _userManager.SetLockoutEnabledAsync(user, true);
                lockUserTask.Wait();

                var lockDateTask = _userManager.SetLockoutEndDateAsync(user, EndDate);
                lockDateTask.Wait();

                Response.StatusCode = (int)HttpStatusCode.OK;
                return Json("usuario " + ((appusuario)user).IDpersona + " bloqueado indefinidamente");
            }
            else
            {

                var LockoutEndDateTask = _userManager.SetLockoutEndDateAsync(user, null);
                LockoutEndDateTask.Wait();
                var lockDisabledTask = _userManager.SetLockoutEnabledAsync(user, false);
                lockDisabledTask.Wait();

                Response.StatusCode = (int)HttpStatusCode.OK;
                return Json("usuario= " + ((appusuario)user).IDpersona + "desbloqueado");
            }

        }

    }
}

   
