using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class IsoProceso
{
    public int Idproceso { get; set; }

    public string Nombre { get; set; }

    public virtual ICollection<IsoActividade> IsoActividades { get; set; } = new List<IsoActividade>();

    public virtual ICollection<IsoIndicadore> IsoIndicadores { get; set; } = new List<IsoIndicadore>();
}
