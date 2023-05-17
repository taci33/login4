using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class PyGCuenta
{
    public int IdpyGCuentas { get; set; }

    public int? PyGid { get; set; }

    public string Cuenta { get; set; }

    public string Signo { get; set; }

    public virtual PyG PyG { get; set; }
}
