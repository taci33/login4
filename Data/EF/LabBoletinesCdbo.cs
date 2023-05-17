using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class LabBoletinesCdbo
{
    public long Idcdbo { get; set; }

    public virtual LabBoletine LabBoletine { get; set; }
}
