using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class LabBoletinesDetalleCdbo
{
    public long Idcdbo { get; set; }

    public virtual LabBoletinesDetalle LabBoletinesDetalle { get; set; }
}
