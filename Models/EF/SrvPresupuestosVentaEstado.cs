using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class SrvPresupuestosVentaEstado
{
    public int Idestado { get; set; }

    public string Nombre { get; set; }

    public string FontColor { get; set; }

    public bool Traspaso { get; set; }

    public bool CantidadPendiente { get; set; }

    public bool? AllowModify { get; set; }

    public virtual ICollection<SrvPresupuestosVentum> SrvPresupuestosVenta { get; set; } = new List<SrvPresupuestosVentum>();

    public virtual ICollection<SrvPresupuestosVentaDetalle> SrvPresupuestosVentaDetalles { get; set; } = new List<SrvPresupuestosVentaDetalle>();
}
