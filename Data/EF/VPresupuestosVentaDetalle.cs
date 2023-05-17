using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class VPresupuestosVentaDetalle
{
    public int? Unidades { get; set; }

    public int ProductoId { get; set; }

    public int? MedidaId { get; set; }

    public int CabeceraId { get; set; }

    public string ConceptoMaestro { get; set; }

    public int Idlinea { get; set; }

    public string Concepto { get; set; }

    public decimal? Cantidad { get; set; }

    public decimal? Precio { get; set; }

    public decimal? BaseImponible { get; set; }

    public int? LineaId { get; set; }

    public decimal CantidadApartado { get; set; }

    public decimal PrecioApartado { get; set; }

    public decimal BaseImponibleApartado { get; set; }

    public decimal CantidadReal { get; set; }

    public decimal PrecioReal { get; set; }

    public decimal BaseImponibleReal { get; set; }

    public int TipoLineaId { get; set; }
}
