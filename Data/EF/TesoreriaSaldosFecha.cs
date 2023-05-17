using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class TesoreriaSaldosFecha
{
    public DateTime Fecha { get; set; }

    public int CuentaEmpresaId { get; set; }

    public decimal Saldo { get; set; }

    public virtual EmpresasCuentasBancaria CuentaEmpresa { get; set; }
}
