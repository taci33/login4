using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class IsoFrecuencia
{
    public int Idfrecuencia { get; set; }

    public string Nombre { get; set; }

    public virtual ICollection<IsoCriteriosEficacium> IsoCriteriosEficacia { get; set; } = new List<IsoCriteriosEficacium>();

    public virtual ICollection<IsoIndicadore> IsoIndicadores { get; set; } = new List<IsoIndicadore>();

    public virtual ICollection<IsoMantenimiento> IsoMantenimientos { get; set; } = new List<IsoMantenimiento>();

    public virtual ICollection<IsoVencimiento> IsoVencimientos { get; set; } = new List<IsoVencimiento>();
}
