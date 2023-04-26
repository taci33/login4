using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class ProductosBaseCdbo
{
    /// <summary>
    /// Hace referencia a la tabla de la que cuelga y es igual a la clave IDCDBO de esa tabla
    /// </summary>
    public long Idcdbo { get; set; }

    public virtual ICollection<ProductosBase> ProductosBases { get; set; } = new List<ProductosBase>();
}
