using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class BoCuenta
{
    public int IdboCuentas { get; set; }

    public int? Boid { get; set; }

    public string Cuenta { get; set; }

    public string Signo { get; set; }

    public virtual Bo Bo { get; set; }
}
