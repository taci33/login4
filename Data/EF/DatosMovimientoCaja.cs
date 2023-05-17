using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class DatosMovimientoCaja
{
    public int CabeceraId { get; set; }

    public decimal? Entra { get; set; }

    public decimal? Sale { get; set; }

    public decimal? Acuenta { get; set; }

    public decimal? DtoTotal { get; set; }
}
