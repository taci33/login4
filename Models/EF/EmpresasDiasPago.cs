using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class EmpresasDiasPago
{
    public int EmpresaId { get; set; }

    public int DiaInicio { get; set; }

    public int DiaFin { get; set; }

    public virtual ConfiguracionEmpresa Empresa { get; set; }
}
