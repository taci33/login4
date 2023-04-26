using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class ProductosAlmacen
{
    public int AlmacenId { get; set; }

    public int UbicacionId { get; set; }

    public int ProductoId { get; set; }

    public int LoteId { get; set; }

    public double StockActual { get; set; }

    public virtual AlmacenesUbicacione AlmacenesUbicacione { get; set; }

    public virtual Lote Lote { get; set; }

    public virtual Producto Producto { get; set; }
}
