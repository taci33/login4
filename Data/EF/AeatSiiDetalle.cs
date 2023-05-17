using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class AeatSiiDetalle
{
    public int Iddetalle { get; set; }

    public int PresentacionId { get; set; }

    public string FacturaNifemisor { get; set; }

    public string FacturaNumero { get; set; }

    public string FacturaNumeroFin { get; set; }

    public DateTime FacturaFecha { get; set; }

    public string FacturaClaveTipo { get; set; }

    public string ContraparteRazonSocial { get; set; }

    public string ContraparteNif { get; set; }

    public string ContraparteNifrepresentante { get; set; }

    public string ContrapartePais { get; set; }

    public string ContraparteClaveIdentificacion { get; set; }

    public string ContraparteIdentificacionPais { get; set; }

    public string FacturasRectificadas { get; set; }

    public string FacturasSimplificadasSustituidas { get; set; }

    public decimal? BaseRectificada { get; set; }

    public decimal? CuotaRectificada { get; set; }

    public decimal? CuotaRecargoRectificada { get; set; }

    public string FacturaRectificativaTipo { get; set; }

    public DateTime? FechaExpedicion { get; set; }

    public DateTime? FechaOperacion { get; set; }

    public decimal? ImporteTotal { get; set; }

    public string OperacionClaveTributaria { get; set; }

    public decimal? BaseImponibleAcoste { get; set; }

    public string OperacionDescripcion { get; set; }

    public string InmuebleSituacion { get; set; }

    public string InmuebleReferenciaCatastral { get; set; }

    public DateTime? FechaCobro { get; set; }

    public decimal? ImporteCobrado { get; set; }

    public string MedioCobro { get; set; }

    public string CuentaBancariaCobro { get; set; }

    public short? EstadoRegistro { get; set; }

    public int? CodigoErrorRegistro { get; set; }

    public string DescripcionErrorRegistro { get; set; }

    public string Csv { get; set; }

    public string FeExentaCausa { get; set; }

    public decimal? FeExentaBaseImponible { get; set; }

    public decimal? FeImporteNoSujeta { get; set; }

    public decimal? FeImporteNoSujetaLocalizacion { get; set; }

    public decimal? FeImporteTransmisionesInmuebles { get; set; }

    public string FeFacturaEmitidaTerceros { get; set; }

    public string FeFacturaVariosDestinatarios { get; set; }

    public string FeBiminorporBonificaciones { get; set; }

    public DateTime? FrFechaRegistroContable { get; set; }

    public decimal? FrCuotaDeducible { get; set; }

    public double? OiTipoOi { get; set; }

    public string OiClaveDeclarado { get; set; }

    public string OiCodigoEstadoMiembro { get; set; }

    public int? OiPlazoOperacion { get; set; }

    public string OiDescripcionBienes { get; set; }

    public string OiDireccionOperadorIntracomunitario { get; set; }

    public string OiOtrasFacturas { get; set; }

    public double? BiProrrataAnualDefinitiva { get; set; }

    public decimal? BiRegularizacionAnualDeduccion { get; set; }

    public string BiIdentificacionEntrega { get; set; }

    public decimal? BiRegularizacionDeduccion { get; set; }

    public DateTime? BiFechaInicioUso { get; set; }

    public string BiIdentificacionBien { get; set; }

    public string FeNoExentaTipoExencion { get; set; }

    public int? FacturaOrigenId { get; set; }

    public bool? ContraparteEsNif { get; set; }
}
