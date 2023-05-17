using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class AtributosTipo
{
    public int Idtipo { get; set; }

    public string Nombre { get; set; }

    public string Hint { get; set; }

    public virtual ICollection<AtributosProducto> AtributosProductos { get; set; } = new List<AtributosProducto>();
}
