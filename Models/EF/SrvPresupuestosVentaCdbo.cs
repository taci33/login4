using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class SrvPresupuestosVentaCdbo
{
    public long Idcdbo { get; set; }

    public virtual SrvPresupuestosVentum SrvPresupuestosVentum { get; set; }
}
