using Microsoft.AspNetCore.Identity;

namespace login4.Pages
{
    public class appusuario : IdentityUser
    {
        [PersonalData]
        public string Nombre { get; set; }
        [PersonalData]
        public string IDpersona { get; set; }
        [PersonalData]
        public string RolAcceso { get; set; }
        //[PersonalData]
        //public string? LastPassword { get; set; }
        //[PersonalData]
        //public DateTime Created { get; set; }
    }
}