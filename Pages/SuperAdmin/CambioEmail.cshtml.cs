using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json.Linq;
using System.IO;
using Newtonsoft.Json;

namespace login4.Pages
{
    public class CambioEmailModel : PageModel
    {
        private readonly IConfiguration _configuration;
        private readonly IHostEnvironment _environment;

        public CambioEmailModel(IConfiguration configuration, IHostEnvironment environment)
        {
            _configuration = configuration;
            _environment = environment;
        }

        public IActionResult OnGet()
        {
            // Obtener los valores predeterminados desde appsettings.json
            EmailHost = _configuration.GetValue<string>("EmailSettings:EmailHost");
            EmailUserName = _configuration.GetValue<string>("EmailSettings:EmailUserName");
            EmailPassword = _configuration.GetValue<string>("EmailSettings:EmailPassword");
            Port = _configuration.GetValue<int>("EmailSettings:Port");

            return Page();
        }

        [BindProperty]
        public string EmailHost { get; set; }

        [BindProperty]
        public string EmailUserName { get; set; }

        [BindProperty]
        public string EmailPassword { get; set; }

        [BindProperty]
        public int Port { get; set; }

        public IActionResult OnPostActualizarConfiguracion()
        {
            if (ModelState.IsValid)
            {
                // Actualiza la configuración en appsettings.json
                _configuration.GetSection("EmailSettings")["EmailHost"] = EmailHost;
                _configuration.GetSection("EmailSettings")["EmailUserName"] = EmailUserName;
                _configuration.GetSection("EmailSettings")["EmailPassword"] = EmailPassword;
                _configuration.GetSection("EmailSettings")["Port"] = Port.ToString();

              
                var configPath = Path.Combine(_environment.ContentRootPath, "appsettings.json");
                var jsonConfig = new JObject();

                

                using (var fileStream = new FileStream(configPath, FileMode.Open, FileAccess.ReadWrite))
                {
                    jsonConfig = JObject.Load(new JsonTextReader(new StreamReader(fileStream)));
                    jsonConfig["EmailSettings"]["EmailHost"] = EmailHost;
                    jsonConfig["EmailSettings"]["EmailUserName"] = EmailUserName;
                    jsonConfig["EmailSettings"]["EmailPassword"] = EmailPassword;
                    jsonConfig["EmailSettings"]["Port"] = Port.ToString();
                    fileStream.Seek(0, SeekOrigin.Begin);
                    fileStream.SetLength(0);
                    using (var writer = new StreamWriter(fileStream))
                    {
                        writer.Write(jsonConfig.ToString());
                        writer.Flush();
                    }
                }

                // Redirige a la misma pagina pero con la configuracion cambiada
                return RedirectToPage("/CambioEmail");
            }

            // Si el modelo no es válido, muestra el formulario nuevamente con los errores
            return Page();
        }
    }
}
