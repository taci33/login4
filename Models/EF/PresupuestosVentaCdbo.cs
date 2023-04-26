using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class PresupuestosVentaCdbo
{
    /// <summary>
    /// Hace referencia a la tabla de la que cuelga y es igual a la clave IDCDBO de esa tabla
    /// </summary>
    public long Idcdbo { get; set; }

    public virtual PresupuestosVentum PresupuestosVentum { get; set; }
}
