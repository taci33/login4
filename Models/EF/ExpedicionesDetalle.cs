using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class ExpedicionesDetalle
{
    public int Idlinea { get; set; }

    public long? Idcdbo { get; set; }

    public int CabeceraId { get; set; }

    public int? LineaId { get; set; }

    public int TipoLineaId { get; set; }

    public int EstadoId { get; set; }

    public int? NumLinea { get; set; }

    public int? DgorigenId { get; set; }

    public int? CabeceraOrigenId { get; set; }

    public string Descripcion { get; set; }

    public string Referencia { get; set; }

    public string Seguimiento { get; set; }

    public string Nenvio { get; set; }

    public int Nbultos { get; set; }

    public double PesoReal { get; set; }

    public double PesoRealFacturable { get; set; }

    public int? PaqueteFormatoId { get; set; }

    public double Largo { get; set; }

    public double Alto { get; set; }

    public double Ancho { get; set; }

    public DateTime? FechaSalida { get; set; }

    public DateTime? FechaEntrega { get; set; }

    public string AvisoTelefono { get; set; }

    public int? DirSalidaEntidadOrigenId { get; set; }

    public int? DirSalidaKeyFieldValueId { get; set; }

    public int? DirSalidaDireccionId { get; set; }

    public int? DirEntregaEntidadOrigenId { get; set; }

    public int? DirEntregaKeyFieldValueId { get; set; }

    public int? DirEntregaDireccionId { get; set; }

    public string DatosAdicionales { get; set; }

    public int? TarifaAgenciaId { get; set; }

    /// <summary>
    /// Espcifica el Tipo refiriéndose al tipo de Servicio: Expedición Normal (0), Recogida (1), etc. Sólo tiene sentido en las líneas GroupHeader, en las hijas (Bultos) se copia el valor del padre
    /// </summary>
    public int TipoId { get; set; }

    public int PortesTipoId { get; set; }

    public bool ContraReembolso { get; set; }

    public decimal ContraReembolsoValor { get; set; }

    public int ContraReembolsoPortesTipoId { get; set; }

    /// <summary>
    /// Email enviado
    /// </summary>
    public bool EmEnviado { get; set; }

    /// <summary>
    /// Email Fecha Envio
    /// </summary>
    public DateTime? EmFenvio { get; set; }

    public float? HoraMannanaDe { get; set; }

    public float? HoraMannanaA { get; set; }

    public float? HoraTardeDe { get; set; }

    public float? HoraTardeA { get; set; }

    public string AvisoEmail { get; set; }

    public string AvisoTelefono2 { get; set; }

    public string AvisoTelefonoOrigen { get; set; }

    public string AvisoTelefono2Origen { get; set; }

    public string AvisoEmailOrigen { get; set; }

    public string DatosAdicionalesOrigen { get; set; }

    public float? HoraMannanaDeOrigen { get; set; }

    public float? HoraMannanaAOrigen { get; set; }

    public float? HoraTardeDeOrigen { get; set; }

    public float? HoraTardeAOrigen { get; set; }

    public virtual Expedicione Cabecera { get; set; }

    public virtual DocumentosGestion Dgorigen { get; set; }

    public virtual DireccionesEntidadesOrigen DirEntregaEntidadOrigen { get; set; }

    public virtual DireccionesEntidadesOrigen DirSalidaEntidadOrigen { get; set; }

    public virtual ExpedicionesEstado Estado { get; set; }

    public virtual ExpedicionesDetalleCdbo IdcdboNavigation { get; set; }

    public virtual ICollection<ExpedicionesDetalle> InverseLinea { get; set; } = new List<ExpedicionesDetalle>();

    public virtual ExpedicionesDetalle Linea { get; set; }

    public virtual ExpPaquetesFormato PaqueteFormato { get; set; }

    public virtual PortesTipo PortesTipo { get; set; }

    public virtual TiposLinea TipoLinea { get; set; }
}
