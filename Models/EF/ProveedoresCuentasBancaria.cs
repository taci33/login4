using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class ProveedoresCuentasBancaria
{
    public int Id { get; set; }

    public int PersonaId { get; set; }

    public string NumCta { get; set; }

    public string Nombre { get; set; }

    public string Swift1 { get; set; }

    public string Swift2 { get; set; }

    public string Swift3 { get; set; }

    public string Swift4 { get; set; }

    public bool? Iban { get; set; }

    public string Ibancodigo { get; set; }

    public string Ibancuenta { get; set; }

    public virtual Proveedore Persona { get; set; }
}
