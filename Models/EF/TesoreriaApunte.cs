using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class TesoreriaApunte
{
    public int Idapunte { get; set; }

    public DateTime Foperacion { get; set; }

    public string Tipo { get; set; }

    public DateTime? Fcargo { get; set; }

    public string Concepto { get; set; }

    public decimal Importe { get; set; }

    public int? VencimientoId { get; set; }

    public int CuentaEmpresaId { get; set; }

    public int? ProcessId { get; set; }

    public int TipoId { get; set; }

    public string Descripcion { get; set; }

    public bool Pagado { get; set; }

    public virtual EmpresasCuentasBancaria CuentaEmpresa { get; set; }

    public virtual TesoreriaApunteTipo TipoNavigation { get; set; }
}
