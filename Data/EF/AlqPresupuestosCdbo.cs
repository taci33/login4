using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class AlqPresupuestosCdbo
{
    public long Idcdbo { get; set; }

    public int? TarifaDiasSemanaId { get; set; }

    public virtual AlqPresupuesto AlqPresupuesto { get; set; }
}
