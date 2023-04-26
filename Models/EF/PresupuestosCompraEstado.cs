using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class PresupuestosCompraEstado
{
    public int Idestado { get; set; }

    public string Nombre { get; set; }

    public string FontColor { get; set; }

    public bool Traspaso { get; set; }

    public bool CantidadPendiente { get; set; }

    public bool? AllowModify { get; set; }

    public virtual ICollection<PresupuestosCompraDetalle> PresupuestosCompraDetalles { get; set; } = new List<PresupuestosCompraDetalle>();

    public virtual ICollection<PresupuestosCompra> PresupuestosCompras { get; set; } = new List<PresupuestosCompra>();
}
