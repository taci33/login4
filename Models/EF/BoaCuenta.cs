using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class BoaCuenta
{
    public int Clave { get; set; }

    public string Cuenta { get; set; }

    public string Signo { get; set; }
}
