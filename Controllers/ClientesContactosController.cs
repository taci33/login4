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
using login4.Controllers;
using login4.Services.EmailService;
using login4.Models;
using Microsoft.AspNetCore.Identity.UI.Services;
using System.Text.Encodings.Web;
using MimeKit;
using System.Resources;

namespace login4.Controllers
{
   
    [Route("api/[controller]/[action]")]
    
    public class ClientesContactosController : Controller

    {
        private readonly UserManager<IdentityUser> _userManager;
        private IntranetSenasaData230209Context _context;
        private readonly IUserStore<IdentityUser> _userStore;
        private readonly IUserEmailStore<IdentityUser> _emailStore;
        private readonly IEmailService _emailService;
        private readonly IWebHostEnvironment _env;
        public object JsonRequestBehavior { get; private set; }

        public ClientesContactosController(
            UserManager<IdentityUser> userManager,
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





        [HttpPost]
        public async Task<IActionResult> Bloquear(string email)
        {
     
            var user = await _userManager.FindByEmailAsync(email);

        if(!user.LockoutEnabled) { 
            var EndDate = new DateTime(2222, 06, 06);
            var lockUserTask = _userManager.SetLockoutEnabledAsync(user, true);
            lockUserTask.Wait();

            var lockDateTask = _userManager.SetLockoutEndDateAsync(user, EndDate);
            lockDateTask.Wait();
             
            Response.StatusCode = (int)HttpStatusCode.OK;
            return Json("usuario " + ((appusuario)user).IDpersona + " bloqueado indefinidamente");
            } else
                {
                
                var LockoutEndDateTask = _userManager.SetLockoutEndDateAsync(user, null);
                LockoutEndDateTask.Wait();
                var lockDisabledTask = _userManager.SetLockoutEnabledAsync(user, false);
                lockDisabledTask.Wait();
               
                Response.StatusCode = (int)HttpStatusCode.OK;
                return Json("usuario= " + ((appusuario)user).IDpersona + "desbloqueado");
                }
        
        }

        

        [HttpPost]
        public async Task<IActionResult> Registrar(string email, string nombre, string idpersona)
        {

            string returnUrl = null;
            returnUrl ??= Url.Content("~/");

            if (await _userManager.FindByEmailAsync(email)== null)
            {
                try{
                    //Generar una contraseña aleatoria
                    var password = GenerateRandomPassword();
                    // Crear un nuevo usuario
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
                        code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
                        // Enviar la confirmacion por correo electrónico

                        var callbackUrl = Url.Page(
                      "/Account/ConfirmEmail",
                      pageHandler: null,
                      values: new { area = "Identity", userId = userId, code = code, returnUrl = returnUrl },
                      protocol: Request.Scheme);

                        var rootPath = _env.WebRootPath; //obtiene la ruta a la carpeta wwwroot
                        var templatename = "mt_registro.html";
                        var templateUrl = rootPath + "\\mail_templates\\" + templatename;

                        var name = ((appusuario)user).Nombre;
                        var link = HtmlEncoder.Default.Encode(callbackUrl);
                        
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
                       
                        var mail = new EmailDto
                        {
                            To = /*email*/"aalbertosanzcarmen@gmail.com",
                            Subject = "prueba",
                            Body = replybody
                        };
                        
                        _emailService.SendEmail(mail);
                        //return RedirectToAction(nameof(SuccessRegistration));
                    }
                    
                    else
                    {
                        foreach (var error in result.Errors)
                        {
                            ModelState.AddModelError(string.Empty, error.Description);
                        }

                    }
                    Response.StatusCode = (int)HttpStatusCode.OK;
                    return Json("contraseña= " + password);
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
            private string GenerateRandomPassword()
            {
            // Generar una contraseña aleatoria utilizando caracteres alfanuméricos
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
        public async Task<IActionResult> ConfirmEmail(string token, string email)
        {
            return View();
        }
        [HttpGet]
        public IActionResult SuccessRegistration()
        {
            return View();
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