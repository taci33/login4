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

namespace login4.Controllers
{
    [Route("api/[controller]/[action]")]
    public class ClientesUsersController : Controller
    {
        private IntranetSenasaData230209Context _context;

        public ClientesUsersController(IntranetSenasaData230209Context context) {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Get(DataSourceLoadOptions loadOptions) {
            var clientesusers = _context.ClientesUsers.Select(i => new {
                i.Id,
                i.UserName,
                i.NormalizedUserName,
                i.Email,
                i.NormalizedEmail,
                i.EmailConfirmed,
                i.PasswordHash,
                i.SecurityStamp,
                i.ConcurrencyStamp,
                i.PhoneNumber,
                i.PhoneNumberConfirmed,
                i.TwoFactorEnabled,
                i.LockoutEnd,
                i.LockoutEnabled,
                i.AccessFailedCount
            });

            // If underlying data is a large SQL table, specify PrimaryKey and PaginateViaPrimaryKey.
            // This can make SQL execution plans more efficient.
            // For more detailed information, please refer to this discussion: https://github.com/DevExpress/DevExtreme.AspNet.Data/issues/336.
            // loadOptions.PrimaryKey = new[] { "Id" };
            // loadOptions.PaginateViaPrimaryKey = true;

            return Json(await DataSourceLoader.LoadAsync(clientesusers, loadOptions));
        }

        [HttpPost]
        public async Task<IActionResult> Post(string values) {
            var model = new ClientesUser();
            var valuesDict = JsonConvert.DeserializeObject<IDictionary>(values);
            PopulateModel(model, valuesDict);

            if(!TryValidateModel(model))
                return BadRequest(GetFullErrorMessage(ModelState));

            var result = _context.ClientesUsers.Add(model);
            await _context.SaveChangesAsync();

            return Json(new { result.Entity.Id });
        }

        [HttpPut]
        public async Task<IActionResult> Put(string key, string values) {
            var model = await _context.ClientesUsers.FirstOrDefaultAsync(item => item.Id == key);
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
        public async Task Delete(string key) {
            var model = await _context.ClientesUsers.FirstOrDefaultAsync(item => item.Id == key);

            _context.ClientesUsers.Remove(model);
            await _context.SaveChangesAsync();
        }


        private void PopulateModel(ClientesUser model, IDictionary values) {
            string ID = nameof(ClientesUser.Id);
            string USER_NAME = nameof(ClientesUser.UserName);
            string NORMALIZED_USER_NAME = nameof(ClientesUser.NormalizedUserName);
            string EMAIL = nameof(ClientesUser.Email);
            string NORMALIZED_EMAIL = nameof(ClientesUser.NormalizedEmail);
            string EMAIL_CONFIRMED = nameof(ClientesUser.EmailConfirmed);
            string PASSWORD_HASH = nameof(ClientesUser.PasswordHash);
            string SECURITY_STAMP = nameof(ClientesUser.SecurityStamp);
            string CONCURRENCY_STAMP = nameof(ClientesUser.ConcurrencyStamp);
            string PHONE_NUMBER = nameof(ClientesUser.PhoneNumber);
            string PHONE_NUMBER_CONFIRMED = nameof(ClientesUser.PhoneNumberConfirmed);
            string TWO_FACTOR_ENABLED = nameof(ClientesUser.TwoFactorEnabled);
            string LOCKOUT_END = nameof(ClientesUser.LockoutEnd);
            string LOCKOUT_ENABLED = nameof(ClientesUser.LockoutEnabled);
            string ACCESS_FAILED_COUNT = nameof(ClientesUser.AccessFailedCount);

            if(values.Contains(ID)) {
                model.Id = Convert.ToString(values[ID]);
            }

            if(values.Contains(USER_NAME)) {
                model.UserName = Convert.ToString(values[USER_NAME]);
            }

            if(values.Contains(NORMALIZED_USER_NAME)) {
                model.NormalizedUserName = Convert.ToString(values[NORMALIZED_USER_NAME]);
            }

            if(values.Contains(EMAIL)) {
                model.Email = Convert.ToString(values[EMAIL]);
            }

            if(values.Contains(NORMALIZED_EMAIL)) {
                model.NormalizedEmail = Convert.ToString(values[NORMALIZED_EMAIL]);
            }

            if(values.Contains(EMAIL_CONFIRMED)) {
                model.EmailConfirmed = Convert.ToBoolean(values[EMAIL_CONFIRMED]);
            }

            if(values.Contains(PASSWORD_HASH)) {
                model.PasswordHash = Convert.ToString(values[PASSWORD_HASH]);
            }

            if(values.Contains(SECURITY_STAMP)) {
                model.SecurityStamp = Convert.ToString(values[SECURITY_STAMP]);
            }

            if(values.Contains(CONCURRENCY_STAMP)) {
                model.ConcurrencyStamp = Convert.ToString(values[CONCURRENCY_STAMP]);
            }

            if(values.Contains(PHONE_NUMBER)) {
                model.PhoneNumber = Convert.ToString(values[PHONE_NUMBER]);
            }

            if(values.Contains(PHONE_NUMBER_CONFIRMED)) {
                model.PhoneNumberConfirmed = Convert.ToBoolean(values[PHONE_NUMBER_CONFIRMED]);
            }

            if(values.Contains(TWO_FACTOR_ENABLED)) {
                model.TwoFactorEnabled = Convert.ToBoolean(values[TWO_FACTOR_ENABLED]);
            }

            if(values.Contains(LOCKOUT_END)) {
                model.LockoutEnd = values[LOCKOUT_END] != null ? ConvertTo<System.DateTimeOffset>(values[LOCKOUT_END]) : (DateTimeOffset?)null;
            }

            if(values.Contains(LOCKOUT_ENABLED)) {
                model.LockoutEnabled = Convert.ToBoolean(values[LOCKOUT_ENABLED]);
            }

            if(values.Contains(ACCESS_FAILED_COUNT)) {
                model.AccessFailedCount = Convert.ToInt32(values[ACCESS_FAILED_COUNT]);
            }
        }

        private T ConvertTo<T>(object value) {
            var converter = System.ComponentModel.TypeDescriptor.GetConverter(typeof(T));
            if(converter != null) {
                return (T)converter.ConvertFrom(null, CultureInfo.InvariantCulture, value);
            } else {
                // If necessary, implement a type conversion here
                throw new NotImplementedException();
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