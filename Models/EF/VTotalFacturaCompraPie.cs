using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class VTotalFacturaCompraPie
{
    public int CabeceraId { get; set; }

    public decimal? SumaBaseImponible { get; set; }

    public decimal? SumaIvapie { get; set; }

    public decimal? SumaTotal { get; set; }
}
