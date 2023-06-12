using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace login4.Pages.SuperAdmin
{
    public class CambioTokenModel : PageModel
    {
        private readonly IConfiguration _configuration;
        private readonly IHostEnvironment _environment;

        public CambioTokenModel(IConfiguration configuration, IHostEnvironment environment)
        {
            _configuration = configuration;
            _environment = environment;
        }
        public IActionResult OnGet()
        {
            // Obtener los valores predeterminados desde appsettings.json
            Duration = _configuration.GetValue<string>("Token:Duration");
            

            return Page();
        }

        [BindProperty]
        public string Duration { get; set; }
        public IActionResult OnPostActualizarConfiguracion()
        {
            if (ModelState.IsValid)
            {
                // Actualiza la configuración en appsettings.json
                _configuration.GetSection("Token")["Duration"] = Duration;
               


                var configPath = Path.Combine(_environment.ContentRootPath, "appsettings.json");
                var jsonConfig = new JObject();



                using (var fileStream = new FileStream(configPath, FileMode.Open, FileAccess.ReadWrite))
                {
                    jsonConfig = JObject.Load(new JsonTextReader(new StreamReader(fileStream)));
                    jsonConfig["Token"]["Duration"] = Duration;
                    
                    fileStream.Seek(0, SeekOrigin.Begin);
                    fileStream.SetLength(0);
                    using (var writer = new StreamWriter(fileStream))
                    {
                        writer.Write(jsonConfig.ToString());
                        writer.Flush();
                    }
                }

                // Redirige a la misma pagina pero con la configuracion cambiada
                return RedirectToPage("/SuperAdmin/CambioToken");
            }

            // Si el modelo no es válido, muestra el formulario nuevamente con los errores
            return Page();
        }
    }
}
