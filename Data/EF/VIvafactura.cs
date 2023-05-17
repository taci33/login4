using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class VIvafactura
{
    public int Idcabecera { get; set; }

    public int? IdivaClase { get; set; }

    public decimal? General { get; set; }

    public string Nombre { get; set; }

    public string CtaIvasoportado { get; set; }
}
