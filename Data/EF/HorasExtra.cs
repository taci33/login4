using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class HorasExtra
{
    public int? CentroId { get; set; }

    public string Empleado { get; set; }

    public DateTime? FechaImputacion { get; set; }

    public decimal? HorasExtras { get; set; }

    public int? Mess { get; set; }

    public int? DíaDelMes { get; set; }

    public int? Anno { get; set; }

    public string Mes { get; set; }

    public decimal Cantidad { get; set; }

    public int TipoOf { get; set; }

    public string Titulo { get; set; }

    public int Documentoid { get; set; }
}
