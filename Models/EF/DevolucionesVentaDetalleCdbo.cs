using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class DevolucionesVentaDetalleCdbo
{
    public long Idcdbo { get; set; }

    public virtual DevolucionesVentaDetalle DevolucionesVentaDetalle { get; set; }
}
