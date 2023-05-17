using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class CrmCanjesDetalle
{
    public int IdcanjeDetalle { get; set; }

    public int CanjeId { get; set; }

    public int PuntosDesde { get; set; }

    public decimal Vale { get; set; }

    public string Obsequio { get; set; }

    public virtual CrmCanje Canje { get; set; }
}
