using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class PermisosEmpleado
{
    public int EmpleadoId { get; set; }

    public int PermisoAccionId { get; set; }

    public bool Enabled { get; set; }

    public virtual Empleado Empleado { get; set; }

    public virtual PermisosAccione PermisoAccion { get; set; }
}
