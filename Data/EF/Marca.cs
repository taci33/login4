using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class Marca
{
    public int Idmarca { get; set; }

    public string Nombre { get; set; }

    public string Codigo { get; set; }

    public string Imagen { get; set; }

    public virtual ICollection<Producto> Productos { get; set; } = new List<Producto>();

    public virtual ICollection<ProductosBase> ProductosBases { get; set; } = new List<ProductosBase>();
}
