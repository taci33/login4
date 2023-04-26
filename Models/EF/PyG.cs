using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class PyG
{
    public int IdpyG { get; set; }

    public int? PyGid { get; set; }

    public string Nombre { get; set; }

    public virtual ICollection<PyG> InversePyGNavigation { get; set; } = new List<PyG>();

    public virtual ICollection<PyGCuenta> PyGCuenta { get; set; } = new List<PyGCuenta>();

    public virtual PyG PyGNavigation { get; set; }
}
