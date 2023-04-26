using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class IsoPedidosCompra
{
    public int CabeceraId { get; set; }

    public bool? Aprobado { get; set; }

    public int? CalificacionId { get; set; }

    public string ObservacionesCalidad { get; set; }

    public virtual PedidosCompra Cabecera { get; set; }

    public virtual IsoCalificacionesCompra Calificacion { get; set; }
}
