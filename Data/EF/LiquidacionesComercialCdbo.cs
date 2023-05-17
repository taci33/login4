using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class LiquidacionesComercialCdbo
{
    public long Idcdbo { get; set; }

    public virtual LiquidacionesComercial LiquidacionesComercial { get; set; }
}
