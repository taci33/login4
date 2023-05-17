using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class ValesCdbo
{
    public long Idcdbo { get; set; }

    public virtual Vale Vale { get; set; }
}
