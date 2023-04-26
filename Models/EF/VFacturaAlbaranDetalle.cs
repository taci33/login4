using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class VFacturaAlbaranDetalle
{
    public string NumeroAlbaran { get; set; }

    public string Observaciones { get; set; }

    public int BaseImponible { get; set; }
}
