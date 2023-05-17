using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class ProveedoresTipo
{
    public int Idtipo { get; set; }

    public string Nombre { get; set; }

    public virtual ICollection<Proveedore> Proveedores { get; set; } = new List<Proveedore>();
}
