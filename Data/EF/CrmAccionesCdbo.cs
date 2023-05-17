using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class CrmAccionesCdbo
{
    public long Idcdbo { get; set; }

    public virtual CrmAccione CrmAccione { get; set; }
}
