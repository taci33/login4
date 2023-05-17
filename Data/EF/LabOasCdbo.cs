using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class LabOasCdbo
{
    public long Idcdbo { get; set; }

    public virtual LabOa LabOa { get; set; }
}
