using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class EmpleadosEstadosCivile
{
    public int IdempleadoEstadoCivil { get; set; }

    public string Nombre { get; set; }

    public virtual ICollection<Empleado> Empleados { get; set; } = new List<Empleado>();
}
