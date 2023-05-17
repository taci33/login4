using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class TpvticketsCdbo
{
    public long Idcdbo { get; set; }

    public virtual Tpvticket Tpvticket { get; set; }
}
