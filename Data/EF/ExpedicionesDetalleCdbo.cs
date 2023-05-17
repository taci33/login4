using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class ExpedicionesDetalleCdbo
{
    public long Idcdbo { get; set; }

    public virtual ExpedicionesDetalle ExpedicionesDetalle { get; set; }
}
