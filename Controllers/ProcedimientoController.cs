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
using login4.Pages;
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

namespace login4.Controllers

{
    [Route("api/[controller]/[action]")]
    public class ProcedimientoController : Controller
    {
        private IntranetSenasaData230209Context _context;

        public ProcedimientoController(IntranetSenasaData230209Context context, IHttpContextAccessor httpContextAccessor, IMemoryCache memoryCache)
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
                var clientes = _context.ext_adm_CL_Searchs
                .FromSqlRaw("exec ext_adm_CL_Search @IDTipo,@LockoutEnabled", clientIdParameter, clientIdParameter2)
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

            //    [HttpGet]
            //public IActionResult Get(DataSourceLoadOptions loadOptions)
            //{
            //    {
            //        SqlCommand command = new("ext_adm_CL_Search");
            //        command.CommandType = CommandType.StoredProcedure;
            //        //command.Parameters.AddWithValue(new SqlParameter("@IDTipo", SqlDbType.Int));
            //        command.Parameters.AddWithValue("@IDTipo", DBNull.Value);
            //        command.Parameters.Add(new SqlParameter("@LockoutEnabled", false));
            //        var clientes = _context.ext_adm_CL_Searchs
            //        SqlDataReader reader = command.ExecuteReader().Select(i => new
            //        {
            //            i.IDPersona,
            //            i.Nombre,
            //            i.NombreComercial,
            //            i.Telefono,
            //            i.Fax,
            //            i.CIF_NIF,
            //            i.Email,
            //            i.PaginaWeb,
            //            i.UsuarioRegistrado,
            //            i.TipoDeCliente,
            //            i.TipoID,
            //            i.LockoutEnabled
            //        })
            //        .ToList();
            //.ToListAsync();

            //        //var clientes = _context.ext_adm_CL_Searchs.Select(i => new { i.IDPersona, i.Nombre });

            //        return Json(DataSourceLoader.Load(clientes, loadOptions));
            //}
            //using (SqlConnection connection = new("Server=SVRSQL2014\\SQLPRUEBAS;Initial Catalog=Extranet_Senasa Data_230209;trustservercertificate=True;User Id=sa;Password=comisiones;"))
            //{


            //using (SqlCommand command = new("ext_adm_CL_Search"))
            //{
            //    command.CommandType = CommandType.StoredProcedure;
            //    //command.Parameters.AddWithValue(new SqlParameter("@IDTipo", SqlDbType.Int));
            //    command.Parameters.AddWithValue("@IDTipo", DBNull.Value);
            //    command.Parameters.Add(new SqlParameter("@LockoutEnabled", false));
            //    await connection.OpenAsync();

            //    using (SqlDataReader reader = await command.ExecuteReaderAsync())
            //    {
            //        while (await reader.ReadAsync())
            //        {
            //            // Leer los valores de las columnas devueltas por el procedimiento almacenado
            //            int IDPersona = Convert.ToInt32(reader["IDPersona"]);
            //            string Nombre = Convert.ToString(reader["Nombre"]);
            //            string NombreComercial = ""; // (string)reader["NombreComercial"];
            //            string Telefono = ""; // (string)reader["Telefono"];
            //            string Fax = ""; // (string)reader["Fax"];
            //                             //                string CIF_NIF = ""; // (string)reader["CIF_NIF"];
            //                string Email = ""; // (string)reader["Email"];
            //                string PaginaWeb = ""; // (string)reader["PaginaWeb"].ToString();
            //                int TipoID = 1; // (int)reader["TipoID"];
            //                Boolean LockoutEnabled = false; // (Boolean)reader["LockoutEnabled"];
            //                // Leer el resto de las columnas y hacer lo necesario con los datos obtenidos
            //            }
            //        }
            //    }
            //}
            ////return Json(await DataSourceLoader.LoadAsync(clientescontactos, loadOptions));
            //return View();  

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
       
        //void PopulateModel(ext_adm_CL_Search cliente, IDictionary values)
        //{
        //    if (values.Contains("IDPersona"))
        //        cliente.TipoID = Convert.ToInt32(values["IDPersona"]);

        //    if (values.Contains("Nombre"))
        //        cliente.Nombre = Convert.ToString(values["Nombre"]);
        //}

    }
}


