using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class EmpleadosDepartamento
{
    public int IdempleadoDepartamento { get; set; }

    public string Nombre { get; set; }

    public string Descripcion { get; set; }

    public virtual ICollection<Empleado> Empleados { get; set; } = new List<Empleado>();
}
