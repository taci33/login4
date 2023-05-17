using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class VPresupuestosVentaCabecera
{
    public int CabeceraId { get; set; }

    public int Idlinea { get; set; }

    public string Descripcion { get; set; }

    public int? LineaId { get; set; }

    public int TipoLineaId { get; set; }

    public decimal Cantidad { get; set; }

    public decimal Precio { get; set; }

    public decimal BaseImponible { get; set; }

    public int? UnidadMedidaId { get; set; }

    public int ProductoId { get; set; }

    public int? MedidaId { get; set; }
}
