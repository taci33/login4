using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class SrvContratosCdbo
{
    public long Idcdbo { get; set; }

    public virtual SrvContrato SrvContrato { get; set; }
}
