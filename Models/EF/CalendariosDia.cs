using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class CalendariosDia
{
    public int CalendarioId { get; set; }

    public int EjercicioId { get; set; }

    public DateTime Fecha { get; set; }

    public int TurnoId { get; set; }

    public int? DiaMes { get; set; }

    public int? DiaAnno { get; set; }

    public int? Mes { get; set; }

    public int? Anno { get; set; }

    public string Descripcion { get; set; }

    public virtual ICollection<CalendarioDiasEmpleado> CalendarioDiasEmpleados { get; set; } = new List<CalendarioDiasEmpleado>();

    public virtual CalendariosEjercicio CalendariosEjercicio { get; set; }

    public virtual Turno Turno { get; set; }
}
