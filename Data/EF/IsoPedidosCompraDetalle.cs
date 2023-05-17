using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class IsoPedidosCompraDetalle
{
    public int LineaId { get; set; }

    public int? CalificacionId { get; set; }

    public bool? Certificado { get; set; }

    public virtual IsoCalificacionesCompra Calificacion { get; set; }

    public virtual PedidosCompraDetalle Linea { get; set; }
}
