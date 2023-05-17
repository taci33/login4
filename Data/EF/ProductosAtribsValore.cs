using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class ProductosAtribsValore
{
    public int Idpav { get; set; }

    public int ProductoId { get; set; }

    public int AtributoProductoId { get; set; }

    public int ValorProductoId { get; set; }

    public int Indice { get; set; }

    public string Nombre { get; set; }

    public virtual AtributosProducto AtributoProducto { get; set; }

    public virtual Producto Producto { get; set; }

    public virtual ValoresProducto ValorProducto { get; set; }
}
