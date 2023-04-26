using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class TiposPorte
{
    public int IdtipoPorte { get; set; }

    public int AtributoId { get; set; }

    public string Nombre { get; set; }

    public bool? PorteDebido { get; set; }
}
