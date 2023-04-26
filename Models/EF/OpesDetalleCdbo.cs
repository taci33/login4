using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class OpesDetalleCdbo
{
    public long Idcdbo { get; set; }

    public virtual OpesDetalle OpesDetalle { get; set; }
}
