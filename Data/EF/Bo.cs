using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class Bo
{
    public int Idbo { get; set; }

    public int? Boid { get; set; }

    public string Nombre { get; set; }

    public virtual ICollection<BoCuenta> BoCuenta { get; set; } = new List<BoCuenta>();

    public virtual Bo BoNavigation { get; set; }

    public virtual ICollection<Bo> InverseBoNavigation { get; set; } = new List<Bo>();
}
