using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class VSumaIva
{
    public int CabeceraId { get; set; }

    public decimal General { get; set; }

    public decimal? Iva { get; set; }
}
