using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class IsoTendencia
{
    public int Idtendencia { get; set; }

    public string Nombre { get; set; }

    public virtual ICollection<IsoIndicadore> IsoIndicadores { get; set; } = new List<IsoIndicadore>();
}
