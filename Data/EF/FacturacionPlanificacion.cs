using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class FacturacionPlanificacion
{
    public int Idplanificacion { get; set; }

    public string Numero { get; set; }

    public DateTime FechaEmision { get; set; }

    public int PersonaId { get; set; }

    public double? Importe { get; set; }

    public int? MedioId { get; set; }

    public int? FormaPagoId { get; set; }

    public string Concepto { get; set; }

    public DateTime FechaPrevista { get; set; }

    public int DocumentoOrigenId { get; set; }

    public int CabeceraOrigenId { get; set; }

    public int? DocumentoDestinoId { get; set; }

    public int? CabeceraDestinoId { get; set; }

    public int? DetalleDestinoId { get; set; }

    public DateTime? FechaDestino { get; set; }

    public int IvaclaseId { get; set; }

    public string CuentaContable { get; set; }

    public virtual FormasPago FormaPago { get; set; }

    public virtual MediosPago Medio { get; set; }
}
