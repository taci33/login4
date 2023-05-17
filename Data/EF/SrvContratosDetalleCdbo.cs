using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class SrvContratosDetalleCdbo
{
    public long Idcdbo { get; set; }

    public virtual SrvContratosDetalle SrvContratosDetalle { get; set; }
}
