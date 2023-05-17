using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class IsoCriteriosEficacium
{
    public int IdcriterioEficacia { get; set; }

    public string Nombre { get; set; }

    public int PlanFormacionId { get; set; }

    public int? FrecuenciaId { get; set; }

    public virtual IsoFrecuencia Frecuencia { get; set; }

    public virtual IsoPlanesFormacion PlanFormacion { get; set; }
}
