using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class TiposDireccion
{
    public int IdtipoDireccion { get; set; }

    public string Nombre { get; set; }

    public bool Externa { get; set; }
}
