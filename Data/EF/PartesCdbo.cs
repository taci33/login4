using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class PartesCdbo
{
    public long Idcdbo { get; set; }

    public virtual Parte Parte { get; set; }
}
