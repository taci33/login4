using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class Periodo
{
    public int IdPeriodo { get; set; }

    public int EjercicioId { get; set; }

    public string Nombre { get; set; }

    public DateTime FechaInicio { get; set; }

    public DateTime FechaFin { get; set; }

    public bool? Cerrado { get; set; }

    public int PeriodoTipoId { get; set; }

    public virtual Ejercicio Ejercicio { get; set; }

    public virtual PeriodosTipo PeriodoTipo { get; set; }
}
