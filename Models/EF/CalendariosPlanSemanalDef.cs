using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class CalendariosPlanSemanalDef
{
    public int CalendarioId { get; set; }

    public int EjercicioId { get; set; }

    public int LunesTurnoId { get; set; }

    public int MartesTurnoId { get; set; }

    public int MiercolesTurnoId { get; set; }

    public int JuevesTurnoId { get; set; }

    public int ViernesTurnoId { get; set; }

    public int SabadoTurnoId { get; set; }

    public int DomingoTurnoId { get; set; }

    public virtual CalendariosEjercicio CalendariosEjercicio { get; set; }

    public virtual Turno DomingoTurno { get; set; }

    public virtual Turno JuevesTurno { get; set; }

    public virtual Turno LunesTurno { get; set; }

    public virtual Turno MartesTurno { get; set; }

    public virtual Turno MiercolesTurno { get; set; }

    public virtual Turno SabadoTurno { get; set; }

    public virtual Turno ViernesTurno { get; set; }
}
