using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class FacturasVentaEstado
{
    public int Idestado { get; set; }

    public string Nombre { get; set; }

    public string FontColor { get; set; }

    public bool Traspaso { get; set; }

    public bool CantidadPendiente { get; set; }

    public bool? AllowModify { get; set; }

    public virtual ICollection<FacturasVentum> FacturasVenta { get; set; } = new List<FacturasVentum>();

    public virtual ICollection<FacturasVentaDetalle> FacturasVentaDetalles { get; set; } = new List<FacturasVentaDetalle>();
}
