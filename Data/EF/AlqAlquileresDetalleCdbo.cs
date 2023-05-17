using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class AlqAlquileresDetalleCdbo
{
    public long Idcdbo { get; set; }

    public virtual AlqAlquileresDetalle AlqAlquileresDetalle { get; set; }
}
