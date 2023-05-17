using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class TpvticketsDetalleCdbo
{
    public long Idcdbo { get; set; }

    public virtual TpvticketsDetalle TpvticketsDetalle { get; set; }
}
