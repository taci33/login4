using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class AeatM340Detalle
{
    public int Iddetalle { get; set; }

    public int ModeloId { get; set; }

    public string Nifdeclarado { get; set; }

    public string NifrepresentanteLegal { get; set; }

    public string RazonSocialDeclarado { get; set; }

    public string CodigoPais { get; set; }

    public string ClaveIdentificacion { get; set; }

    public string NifPaisResidencia { get; set; }

    public string ClaveTipoLibro { get; set; }

    public string ClaveOperacion { get; set; }

    public DateTime FechaExpedicion { get; set; }

    public DateTime? FechaOperacion { get; set; }

    public decimal TipoImpositivo { get; set; }

    public decimal BaseImponible { get; set; }

    public decimal CuotaImpuesto { get; set; }

    public decimal ImporteTotal { get; set; }

    public decimal? BaseImponibleAcoste { get; set; }

    public string CodigoFactura { get; set; }

    public int NumeroRegistro { get; set; }

    public int? Nfacturas { get; set; }

    public int? Nregistros { get; set; }

    public int? IntervaloAcumulacionInicio { get; set; }

    public int? IntervaloAcumulacionFin { get; set; }

    public string FacturaRectificada { get; set; }

    public decimal? RecargoEqTipo { get; set; }

    public decimal? RecargoEqCuota { get; set; }

    public int? InmuebleSituacion { get; set; }

    public string ReferenciaCatastral { get; set; }

    public decimal? ImporteMetalico { get; set; }

    public decimal? ImporteTransmisionesInmuebles { get; set; }

    public DateTime? CobroFecha { get; set; }

    public decimal? CobroImporte { get; set; }

    public string CobroMedio { get; set; }

    public string CobroCuenta { get; set; }

    public string ProrrataAnualDefinitiva { get; set; }

    public decimal? RegularizacionAnualDeduccion { get; set; }

    public string IdentificacionEntrega { get; set; }

    public decimal? RegularizacionDeduccionEfectuad { get; set; }

    public DateTime? FechaInicioUtilizacion { get; set; }

    public DateTime? IdentificacionBien { get; set; }

    public string TipoOperacionIntracomunitari { get; set; }

    public string ClaveDeclarado { get; set; }

    public string CodigoEstadoMiembro { get; set; }

    public int? PlazoOperacion { get; set; }

    public string DescripcionBienes { get; set; }

    public string DireccionOperadorIntracomunitarioDomicilio { get; set; }

    public string DireccionOperadorIntracomunitarioPoblacion { get; set; }

    public string DireccionOperadorIntracomunitarioCp { get; set; }

    public virtual AeatM340 Modelo { get; set; }
}
