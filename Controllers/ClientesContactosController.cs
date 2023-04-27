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

namespace login4.Controllers
{
   
    [Route("api/[controller]/[action]")]
    
    public class ClientesContactosController : Controller
    {
        private IntranetSenasaData230209Context _context;

        public ClientesContactosController(IntranetSenasaData230209Context context) {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Get(DataSourceLoadOptions loadOptions) {
            var clientescontactos = _context.ClientesContactos.Select(i => new {
                i.Id,
                i.PersonaId,
                i.Nombre,
                i.Apellidos,
                i.Telefono1,
                i.Telefono2,
                i.Email,
                i.Cargo,
                i.Departamento,
                i.Notas,
                i.PersonaDireccionId,
                i.ContactoTipoId
            });

            // If underlying data is a large SQL table, specify PrimaryKey and PaginateViaPrimaryKey.
            // This can make SQL execution plans more efficient.
            // For more detailed information, please refer to this discussion: https://github.com/DevExpress/DevExtreme.AspNet.Data/issues/336.
            // loadOptions.PrimaryKey = new[] { "Id" };
            // loadOptions.PaginateViaPrimaryKey = true;

            return Json(await DataSourceLoader.LoadAsync(clientescontactos, loadOptions));
        }

        [HttpPost]
        public async Task<IActionResult> Post(string values) {
            var model = new ClientesContacto();
            var valuesDict = JsonConvert.DeserializeObject<IDictionary>(values);
            PopulateModel(model, valuesDict);

            if(!TryValidateModel(model))
                return BadRequest(GetFullErrorMessage(ModelState));

            var result = _context.ClientesContactos.Add(model);
            await _context.SaveChangesAsync();

            return Json(new { result.Entity.Id });
        }

        [HttpPut]
        public async Task<IActionResult> Put(int key, string values) {
            var model = await _context.ClientesContactos.FirstOrDefaultAsync(item => item.Id == key);
            if(model == null)
                return StatusCode(409, "Object not found");

            var valuesDict = JsonConvert.DeserializeObject<IDictionary>(values);
            PopulateModel(model, valuesDict);

            if(!TryValidateModel(model))
                return BadRequest(GetFullErrorMessage(ModelState));

            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete]
        public async Task Delete(int key) {
            var model = await _context.ClientesContactos.FirstOrDefaultAsync(item => item.Id == key);

            _context.ClientesContactos.Remove(model);
            await _context.SaveChangesAsync();
        }


        private void PopulateModel(ClientesContacto model, IDictionary values) {
            string ID = nameof(ClientesContacto.Id);
            string PERSONA_ID = nameof(ClientesContacto.PersonaId);
            string NOMBRE = nameof(ClientesContacto.Nombre);
            string APELLIDOS = nameof(ClientesContacto.Apellidos);
            string TELEFONO1 = nameof(ClientesContacto.Telefono1);
            string TELEFONO2 = nameof(ClientesContacto.Telefono2);
            string EMAIL = nameof(ClientesContacto.Email);
            string CARGO = nameof(ClientesContacto.Cargo);
            string DEPARTAMENTO = nameof(ClientesContacto.Departamento);
            string NOTAS = nameof(ClientesContacto.Notas);
            string PERSONA_DIRECCION_ID = nameof(ClientesContacto.PersonaDireccionId);
            string CONTACTO_TIPO_ID = nameof(ClientesContacto.ContactoTipoId);

            if(values.Contains(ID)) {
                model.Id = Convert.ToInt32(values[ID]);
            }

            if(values.Contains(PERSONA_ID)) {
                model.PersonaId = Convert.ToInt32(values[PERSONA_ID]);
            }

            if(values.Contains(NOMBRE)) {
                model.Nombre = Convert.ToString(values[NOMBRE]);
            }

            if(values.Contains(APELLIDOS)) {
                model.Apellidos = Convert.ToString(values[APELLIDOS]);
            }

            if(values.Contains(TELEFONO1)) {
                model.Telefono1 = Convert.ToString(values[TELEFONO1]);
            }

            if(values.Contains(TELEFONO2)) {
                model.Telefono2 = Convert.ToString(values[TELEFONO2]);
            }

            if(values.Contains(EMAIL)) {
                model.Email = Convert.ToString(values[EMAIL]);
            }

            if(values.Contains(CARGO)) {
                model.Cargo = Convert.ToString(values[CARGO]);
            }

            if(values.Contains(DEPARTAMENTO)) {
                model.Departamento = Convert.ToString(values[DEPARTAMENTO]);
            }

            if(values.Contains(NOTAS)) {
                model.Notas = Convert.ToString(values[NOTAS]);
            }

            if(values.Contains(PERSONA_DIRECCION_ID)) {
                model.PersonaDireccionId = values[PERSONA_DIRECCION_ID] != null ? Convert.ToInt32(values[PERSONA_DIRECCION_ID]) : (int?)null;
            }

            if(values.Contains(CONTACTO_TIPO_ID)) {
                model.ContactoTipoId = Convert.ToInt32(values[CONTACTO_TIPO_ID]);
            }
        }

        private string GetFullErrorMessage(ModelStateDictionary modelState) {
            var messages = new List<string>();

            foreach(var entry in modelState) {
                foreach(var error in entry.Value.Errors)
                    messages.Add(error.ErrorMessage);
            }

            return String.Join(" ", messages);
        }
    }
}