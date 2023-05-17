using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class CrmCampanyasDetalleCdbo
{
    public long Idcdbo { get; set; }

    public virtual CrmCampanyasDetalle CrmCampanyasDetalle { get; set; }
}
