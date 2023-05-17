using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class ValesDetalleCdbo
{
    public long Idcdbo { get; set; }

    public virtual ValesDetalle ValesDetalle { get; set; }
}
