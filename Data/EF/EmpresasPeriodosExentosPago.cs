using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class EmpresasPeriodosExentosPago
{
    public int EmpresaId { get; set; }

    public DateTime FechaInicio { get; set; }

    public DateTime FechaFin { get; set; }

    public string Nombre { get; set; }

    public virtual ConfiguracionEmpresa Empresa { get; set; }
}
