using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class TpvpagosPorCaja
{
    public int IdtpvpagoPorCaja { get; set; }

    public int Tpvid { get; set; }

    public int EmpleadoId { get; set; }

    public DateTime Fecha { get; set; }

    public string Concepto { get; set; }

    public decimal Importe { get; set; }

    public virtual Empleado Empleado { get; set; }

    public virtual Tpv Tpv { get; set; }
}
