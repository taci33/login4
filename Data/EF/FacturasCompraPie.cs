using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class FacturasCompraPie
{
    public int CabeceraId { get; set; }

    public int IvaclaseId { get; set; }

    public int IvagrupoId { get; set; }

    public int RecargoEquivalencia { get; set; }

    public decimal Ivaporcentaje { get; set; }

    public decimal BaseImponible { get; set; }

    public decimal? Importe { get; set; }

    public decimal? ImporteRecargo { get; set; }

    public int? IvatipoId { get; set; }

    public virtual FacturasCompra Cabecera { get; set; }

    public virtual IvaClase Ivaclase { get; set; }

    public virtual Ivagrupo Ivagrupo { get; set; }

    public virtual IvaTipo Ivatipo { get; set; }
}
