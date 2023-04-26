using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class DevolucionesVentaEstado
{
    public int Idestado { get; set; }

    public string Nombre { get; set; }

    public string FontColor { get; set; }

    public bool Traspaso { get; set; }

    public bool CantidadPendiente { get; set; }

    public bool? AllowModify { get; set; }

    public virtual ICollection<DevolucionesVentum> DevolucionesVenta { get; set; } = new List<DevolucionesVentum>();

    public virtual ICollection<DevolucionesVentaDetalle> DevolucionesVentaDetalles { get; set; } = new List<DevolucionesVentaDetalle>();
}
