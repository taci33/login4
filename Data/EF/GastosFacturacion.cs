using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class GastosFacturacion
{
    public int IdgastoFacturacion { get; set; }

    public string Nombre { get; set; }

    public int? IvagrupoCompraId { get; set; }

    public int? IvagrupoVentaId { get; set; }

    public int IvaclaseId { get; set; }

    public decimal? Ivaporcentaje { get; set; }

    public string CtaCompras { get; set; }

    public string CtaVentas { get; set; }

    public virtual IvaClase Ivaclase { get; set; }
}
