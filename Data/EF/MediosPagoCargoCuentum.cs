using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class MediosPagoCargoCuentum
{
    /// <summary>
    /// 1 Sin Cuenta, 2 Cuenta Empresa, 3 Cuenta Destinatario
    /// </summary>
    public int IdcuentaCargo { get; set; }

    public string Nombre { get; set; }

    public virtual ICollection<MediosPago> MediosPagos { get; set; } = new List<MediosPago>();
}
