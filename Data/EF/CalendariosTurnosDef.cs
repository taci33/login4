using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class CalendariosTurnosDef
{
    public int CalendarioId { get; set; }

    public int EjercicioId { get; set; }

    public DateTime FechaInicio { get; set; }

    public DateTime FechaFin { get; set; }

    public int TurnoId { get; set; }

    public string Nombre { get; set; }

    public virtual CalendariosEjercicio CalendariosEjercicio { get; set; }
}
