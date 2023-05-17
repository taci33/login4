using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class CtaCuentasIntercambio
{
    public int Idintercambio { get; set; }

    public int? EmpleadoId { get; set; }

    public DateTime FechaAlta { get; set; }

    public string CuentaOrigen { get; set; }

    public string CuentaDestino { get; set; }

    public DateTime? FechaDesde { get; set; }

    public DateTime? FechaHasta { get; set; }

    public string Descripcion { get; set; }

    public virtual Empleado Empleado { get; set; }
}
