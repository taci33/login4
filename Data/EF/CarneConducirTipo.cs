using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class CarneConducirTipo
{
    public int Idtipo { get; set; }

    public string Nombre { get; set; }

    public virtual ICollection<Empleado> Empleados { get; set; } = new List<Empleado>();
}
