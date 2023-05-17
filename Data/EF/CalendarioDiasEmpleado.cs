using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class CalendarioDiasEmpleado
{
    public int CalendarioId { get; set; }

    public int EjercicioId { get; set; }

    public DateTime Fecha { get; set; }

    public int EmpleadoId { get; set; }

    public int TurnoId { get; set; }

    public string Descripcion { get; set; }

    public virtual CalendariosDia CalendariosDia { get; set; }

    public virtual Empleado Empleado { get; set; }

    public virtual Turno Turno { get; set; }
}
