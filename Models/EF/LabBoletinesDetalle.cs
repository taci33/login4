using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class LabBoletinesDetalle
{
    public int Idlinea { get; set; }

    public long? Idcdbo { get; set; }

    public int CabeceraId { get; set; }

    public int? LineaId { get; set; }

    public int? NumLinea { get; set; }

    public int TipoLineaId { get; set; }

    public int EstadoId { get; set; }

    public int ProductoId { get; set; }

    public int? MedidaId { get; set; }

    public int? UnidadMedidaId { get; set; }

    public string Descripcion { get; set; }

    public double Cantidad { get; set; }

    public double CantidadServida { get; set; }

    public double CantidadPendiente { get; set; }

    public string RefPersona { get; set; }

    public string CodigoMuestra { get; set; }

    public int? DireccionRecogidaId { get; set; }

    public string PuntoMuestreo { get; set; }

    public string ResponsableMuestreo { get; set; }

    public DateTime? Frecepcion { get; set; }

    public DateTime? Frecogida { get; set; }

    public DateTime? Fprevista { get; set; }

    public string Observaciones { get; set; }

    public int? IvaclaseId { get; set; }

    public decimal Descuento { get; set; }

    public double Precio { get; set; }

    public double Coste { get; set; }

    public decimal Margen { get; set; }

    public decimal BaseImponible { get; set; }

    public decimal Total { get; set; }

    public decimal TotalCoste { get; set; }

    public int? IvagrupoId { get; set; }

    public string CtaConta { get; set; }

    public int? LoteId { get; set; }

    public decimal Retencion { get; set; }

    public int? ConceptoRetencionId { get; set; }

    public bool RecargoEquivalencia { get; set; }

    public string CodigoPropioProducto { get; set; }

    public string NumeroLote { get; set; }

    public DateTime? Fentrega { get; set; }

    public Guid? UidId { get; set; }

    public string ActaMuestreo { get; set; }

    public int? ResponsableRecepcionId { get; set; }

    public string Envase { get; set; }

    public int Nenvases { get; set; }

    public double TempEntrada { get; set; }

    public int? TarifaId { get; set; }

    public int? PrioridadId { get; set; }

    public string ProcedimientoEnsayo { get; set; }

    public string TecnicaAnalisis { get; set; }

    public string Unidades { get; set; }

    public string LimiteCuantificacion { get; set; }

    public string LimiteDeteccion { get; set; }

    public string ValorParametrico { get; set; }

    public double TiempoMaximo { get; set; }

    public double TiempoEspera { get; set; }

    public string Acondicionamiento { get; set; }

    public decimal? Incertidumbre { get; set; }

    public string LimiteMaximo { get; set; }

    public bool Acreditado { get; set; }

    public int? ProductoCompuestoId { get; set; }

    public string ProcedimientoMuestreo { get; set; }

    public string EnvaseMuestra { get; set; }

    public bool NecesitaAcondicionamiento { get; set; }

    public int? CentroCosteId { get; set; }

    public string IdentificacionMuestra { get; set; }

    public int MargenTipoId { get; set; }

    public decimal MargenBeneficio { get; set; }

    public decimal TotalBeneficio { get; set; }

    public int? IvaTipoId { get; set; }

    public string Legislacion { get; set; }

    public string TempEntradaMuestra { get; set; }

    public double CosteSinDto { get; set; }

    public decimal DtoCoste { get; set; }

    public int NumeroManipulaciones { get; set; }

    public int? ProcedimientoEnsayoId { get; set; }

    public int? AnalisisTipoId { get; set; }

    public bool? VisiblePuntoEntrega { get; set; }

    public int? PuntoMuestreoSinac { get; set; }

    public DateTime? FrecogidaFin { get; set; }

    public virtual LabAnalisisTipo AnalisisTipo { get; set; }

    public virtual LabBoletine Cabecera { get; set; }

    public virtual CtaCentroCoste CentroCoste { get; set; }

    public virtual ConceptosRetencion ConceptoRetencion { get; set; }

    public virtual LabBoletinesEstado Estado { get; set; }

    public virtual LabBoletinesDetalleCdbo IdcdboNavigation { get; set; }

    public virtual ICollection<LabBoletinesDetalle> InverseLinea { get; set; } = new List<LabBoletinesDetalle>();

    public virtual IvaTipo IvaTipo { get; set; }

    public virtual IvaClase Ivaclase { get; set; }

    public virtual Ivagrupo Ivagrupo { get; set; }

    public virtual ICollection<LabBoletinesDetalleDatosDinamico> LabBoletinesDetalleDatosDinamicos { get; set; } = new List<LabBoletinesDetalleDatosDinamico>();

    public virtual ICollection<LabBoletinesPoolDetalle> LabBoletinesPoolDetalles { get; set; } = new List<LabBoletinesPoolDetalle>();

    public virtual LabBoletinesDetalle Linea { get; set; }

    public virtual MargenesTipo MargenTipo { get; set; }

    public virtual Medida Medida { get; set; }

    public virtual Producto Producto { get; set; }

    public virtual Producto ProductoCompuesto { get; set; }

    public virtual Empleado ResponsableRecepcion { get; set; }

    public virtual Tarifa Tarifa { get; set; }

    public virtual TiposLinea TipoLinea { get; set; }

    public virtual UnidadesMedidum UnidadMedida { get; set; }
}
