using Microsoft.AspNetCore.Identity;

namespace login4.Pages
{
    public class appusuario : IdentityUser
    {

        public string Nombre { get; set; }
        public string IDpersona { get; set; }
        public string RolAcceso { get; set; }

    }
}