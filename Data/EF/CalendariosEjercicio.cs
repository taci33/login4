using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class CalendariosEjercicio
{
    public int CalendarioId { get; set; }

    public int EjercicioId { get; set; }

    public string Nombre { get; set; }

    public virtual Calendario Calendario { get; set; }

    public virtual ICollection<CalendariosDia> CalendariosDia { get; set; } = new List<CalendariosDia>();

    public virtual CalendariosPlanSemanalDef CalendariosPlanSemanalDef { get; set; }

    public virtual ICollection<CalendariosTurnosDef> CalendariosTurnosDefs { get; set; } = new List<CalendariosTurnosDef>();

    public virtual Ejercicio Ejercicio { get; set; }
}
