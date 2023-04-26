using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class ProveedoresTarifasProducto
{
    public int PtpId { get; set; }

    public int PtpRefPo { get; set; }

    public int PtpRefPr { get; set; }

    public decimal PtpPrecioCompra { get; set; }
}
