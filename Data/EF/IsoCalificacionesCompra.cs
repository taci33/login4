using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class IsoCalificacionesCompra
{
    public int Idcalificacion { get; set; }

    public string Nombre { get; set; }

    public virtual ICollection<IsoPedidosCompraDetalle> IsoPedidosCompraDetalles { get; set; } = new List<IsoPedidosCompraDetalle>();

    public virtual ICollection<IsoPedidosCompra> IsoPedidosCompras { get; set; } = new List<IsoPedidosCompra>();
}
