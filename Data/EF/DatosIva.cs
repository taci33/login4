using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class DatosIva
{
    public decimal? Dinero { get; set; }

    public decimal General { get; set; }

    public int CabeceraId { get; set; }
}
