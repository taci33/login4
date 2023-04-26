using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class IsoProducto
{
    public int ProductoId { get; set; }

    public string BuenasPracticas { get; set; }

    public virtual Producto Producto { get; set; }
}
