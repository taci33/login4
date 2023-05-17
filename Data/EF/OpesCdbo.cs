using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class OpesCdbo
{
    public long Idcdbo { get; set; }

    public virtual Ope Ope { get; set; }
}
