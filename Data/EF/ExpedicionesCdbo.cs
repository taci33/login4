using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class ExpedicionesCdbo
{
    public long Idcdbo { get; set; }

    public virtual Expedicione Expedicione { get; set; }
}
