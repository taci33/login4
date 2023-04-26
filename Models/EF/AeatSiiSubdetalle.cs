using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class AeatSiiSubdetalle
{
    public int Idsubdetalle { get; set; }

    public int? DetalleId { get; set; }

    public decimal? FeNoExentaBaseImponible { get; set; }

    public decimal? FeNoExentaCuota { get; set; }

    public double? FeNoExentaTipoRe { get; set; }

    public decimal? FeNoExentaCuotaRe { get; set; }

    public double? FrIspTipo { get; set; }

    public decimal? FrIspBi { get; set; }

    public decimal? FrIspCuota { get; set; }

    public double? FrIspTipoRe { get; set; }

    public decimal? FrIspCuotaRe { get; set; }

    public double? FrTipo { get; set; }

    public decimal? FrBi { get; set; }

    public decimal? FrCuota { get; set; }

    public double? FrTipoRe { get; set; }

    public decimal? FrCuotaRe { get; set; }

    public double? FrPercentCompensacionReagyp { get; set; }

    public decimal? FrCompensacionReagyp { get; set; }

    public double? FeNoExentaTipo { get; set; }
}
