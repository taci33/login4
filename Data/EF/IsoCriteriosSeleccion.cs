using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class IsoCriteriosSeleccion
{
    public int Idcriterio { get; set; }

    public string Nombre { get; set; }

    public virtual ICollection<Proveedore> Personas { get; set; } = new List<Proveedore>();
}
