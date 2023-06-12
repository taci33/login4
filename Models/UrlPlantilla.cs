namespace login4.Models
{
    public class UrlPlantilla
    {

        private readonly IWebHostEnvironment _env;

        public UrlPlantilla(IWebHostEnvironment env)
        {
            _env = env;
        }


        public string UrlTemplate(string templatename)
        {
            var rootPath = _env.WebRootPath;
            var templateUrl = rootPath + "\\mail_templates\\" + templatename;
            return templateUrl;
        }

    }
}
