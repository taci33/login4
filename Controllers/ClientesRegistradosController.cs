using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using login4.Models.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Caching.Memory;
using System.Data;

namespace login4.Controllers
{
    [Route("api/[controller]/[action]")]
    public class ClientesRegistradosController : Controller
    {

        private IntranetSenasaData230209Context _context;
        public ClientesRegistradosController(IntranetSenasaData230209Context context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get(DataSourceLoadOptions loadOptions)
        {
            {
                var clientIdParameter = new SqlParameter("@IDTipo", SqlDbType.Int);
                clientIdParameter.Value = DBNull.Value;
                var clientIdParameter2 = new SqlParameter("@LockoutEnabled", false);
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

                return View();
            }
        }






    }
}

