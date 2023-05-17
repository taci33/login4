using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace login4.Models.EF
{
  
    public class ext_adm_CL_Search
    {

        public int IDPersona { get; set; }
        public string Nombre { get; set; }
        public string NombreComercial { get; set; }
        public string Telefono { get; set; }
        public string Fax { get; set; }
        public string CIF_NIF { get; set; }
        public string Email { get; set; }
        public string PaginaWeb { get; set; }
        public bool UsuarioRegistrado { get; set; }
        public string TipoDeCliente { get; set; }
        public int TipoID { get; set; }
        public bool LockoutEnabled { get; set; }

    }
}