using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class DevolucionesVentaCdbo
{
    public long Idcdbo { get; set; }

    public virtual DevolucionesVentum DevolucionesVentum { get; set; }
}
