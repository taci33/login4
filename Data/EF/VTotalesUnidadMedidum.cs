using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class VTotalesUnidadMedidum
{
    public decimal? Expr1 { get; set; }

    public int TipoLineaId { get; set; }

    public string Abreviatura { get; set; }

    public int CabeceraId { get; set; }

    public int MedidaId { get; set; }
}
