using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class ProductosEstado
{
    public int IdproductoEstado { get; set; }

    public string Nombre { get; set; }

    public virtual ICollection<Producto> Productos { get; set; } = new List<Producto>();

    public virtual ICollection<ProductosBase> ProductosBases { get; set; } = new List<ProductosBase>();
}
