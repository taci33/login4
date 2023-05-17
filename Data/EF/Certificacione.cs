using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class Certificacione
{
    public int Idcertificacion { get; set; }

    public int DocumentoOrigenId { get; set; }

    public int CabeceraOrigenId { get; set; }

    public string Numero { get; set; }

    public DateTime FechaEmision { get; set; }

    public int PersonaId { get; set; }

    public double? Importe { get; set; }

    public int? MedioId { get; set; }

    public int? FormaPagoId { get; set; }

    public int IvaclaseId { get; set; }

    public string CuentaContable { get; set; }

    public string Concepto { get; set; }

    public int? FacturaDestinoId { get; set; }

    public int? FacturaDetalleDestinoId { get; set; }

    public DateTime? FechaFactura { get; set; }

    public int? Avdliquidacion { get; set; }

    public virtual AlbaranesVentaDetalle AvdliquidacionNavigation { get; set; }

    public virtual FacturasVentaDetalle FacturaDetalleDestino { get; set; }

    public virtual FormasPago FormaPago { get; set; }

    public virtual MediosPago Medio { get; set; }
}
