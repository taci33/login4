using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class CrmCampanyasCdbo
{
    public long Idcdbo { get; set; }

    public virtual CrmCampanya CrmCampanya { get; set; }
}
