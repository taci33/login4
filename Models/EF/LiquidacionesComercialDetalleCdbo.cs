using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class LiquidacionesComercialDetalleCdbo
{
    public long Idcdbo { get; set; }

    public virtual LiquidacionesComercialDetalle LiquidacionesComercialDetalle { get; set; }
}
