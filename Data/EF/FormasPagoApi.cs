using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class FormasPagoApi
{
    public int IdformaPagoApi { get; set; }

    public int? FormaPagoId { get; set; }

    public byte[] PubKey { get; set; }

    public byte[] SecKey { get; set; }

    public string Urlprefix { get; set; }

    public virtual FormasPago FormaPago { get; set; }
}
