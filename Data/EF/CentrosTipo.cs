using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class CentrosTipo
{
    public int IdcentroTipo { get; set; }

    public string Nombre { get; set; }

    public string TablaLookup { get; set; }

    public string CampoLookup { get; set; }

    public string CampoResultado { get; set; }

    public bool ConOperacion { get; set; }

    public bool ConCualificacion { get; set; }

    public virtual ICollection<Parte> Partes { get; set; } = new List<Parte>();
}
