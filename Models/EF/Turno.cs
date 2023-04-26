using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class Turno
{
    public int Idturno { get; set; }

    public string Nombre { get; set; }

    public double HoraInicio { get; set; }

    public double HoraFin { get; set; }

    public double HoraInicio2 { get; set; }

    public double HoraFin2 { get; set; }

    public double? TotalHoras { get; set; }

    public string FontColor { get; set; }

    public bool Especial { get; set; }

    public virtual ICollection<CalendarioDiasEmpleado> CalendarioDiasEmpleados { get; set; } = new List<CalendarioDiasEmpleado>();

    public virtual ICollection<CalendariosDia> CalendariosDia { get; set; } = new List<CalendariosDia>();

    public virtual ICollection<CalendariosPlanSemanalDef> CalendariosPlanSemanalDefDomingoTurnos { get; set; } = new List<CalendariosPlanSemanalDef>();

    public virtual ICollection<CalendariosPlanSemanalDef> CalendariosPlanSemanalDefJuevesTurnos { get; set; } = new List<CalendariosPlanSemanalDef>();

    public virtual ICollection<CalendariosPlanSemanalDef> CalendariosPlanSemanalDefLunesTurnos { get; set; } = new List<CalendariosPlanSemanalDef>();

    public virtual ICollection<CalendariosPlanSemanalDef> CalendariosPlanSemanalDefMartesTurnos { get; set; } = new List<CalendariosPlanSemanalDef>();

    public virtual ICollection<CalendariosPlanSemanalDef> CalendariosPlanSemanalDefMiercolesTurnos { get; set; } = new List<CalendariosPlanSemanalDef>();

    public virtual ICollection<CalendariosPlanSemanalDef> CalendariosPlanSemanalDefSabadoTurnos { get; set; } = new List<CalendariosPlanSemanalDef>();

    public virtual ICollection<CalendariosPlanSemanalDef> CalendariosPlanSemanalDefViernesTurnos { get; set; } = new List<CalendariosPlanSemanalDef>();

    public virtual ICollection<Fichaje> Fichajes { get; set; } = new List<Fichaje>();

    public virtual ICollection<RrhhPrimasLiquidacionDetalle> RrhhPrimasLiquidacionDetalles { get; set; } = new List<RrhhPrimasLiquidacionDetalle>();
}
