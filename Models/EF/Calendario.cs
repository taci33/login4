using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class Calendario
{
    public int Idcalendario { get; set; }

    public string Nombre { get; set; }

    public virtual ICollection<CalendariosEjercicio> CalendariosEjercicios { get; set; } = new List<CalendariosEjercicio>();

    public virtual ICollection<Empleado> Empleados { get; set; } = new List<Empleado>();
}
