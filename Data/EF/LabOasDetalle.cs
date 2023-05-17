using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class LabOasDetalle
{
    public int Idlinea { get; set; }

    public long? Idcdbo { get; set; }

    public int CabeceraId { get; set; }

    public int? NumLinea { get; set; }

    public int EstadoId { get; set; }

    public int ProductoId { get; set; }

    public string Descripcion { get; set; }

    public int? ResponsableId { get; set; }

    public DateTime? Fprevista { get; set; }

    public DateTime? Freal { get; set; }

    public string Resultado { get; set; }

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

    public int? MedidaId { get; set; }

    public int? UnidadMedidaId { get; set; }

    public string CtaConta { get; set; }

    public string RefPersona { get; set; }

    public int? LoteId { get; set; }

    public decimal Retencion { get; set; }

    public int? ConceptoRetencionId { get; set; }

    public bool RecargoEquivalencia { get; set; }

    public string CodigoPropioProducto { get; set; }

    public string NumeroLote { get; set; }

    public DateTime? Fentrega { get; set; }

    public Guid? UidId { get; set; }

    public int TipoLineaId { get; set; }

    public int? LineaId { get; set; }

    public double Cantidad { get; set; }

    public DateTime? Frecepcion { get; set; }

    public string ProcedimientoEnsayo { get; set; }

    public string TecnicaAnalisis { get; set; }

    public string Unidades { get; set; }

    public string LimiteCuantificacion { get; set; }

    public string LimiteDeteccion { get; set; }

    public string ValorParametrico { get; set; }

    public double TiempoMaximo { get; set; }

    public double TiempoEspera { get; set; }

    public string Acondicionamiento { get; set; }

    public string Envase { get; set; }

    public decimal? Incertidumbre { get; set; }

    public string LimiteMaximo { get; set; }

    public bool Acreditado { get; set; }

    public int? ProductoCompuestoId { get; set; }

    public int? CentroCosteId { get; set; }

    public int MargenTipoId { get; set; }

    public decimal MargenBeneficio { get; set; }

    public decimal TotalBeneficio { get; set; }

    public int? IvaTipoId { get; set; }

    public bool Impreso { get; set; }

    public bool ImpresoOt { get; set; }

    public double CosteSinDto { get; set; }

    public decimal DtoCoste { get; set; }

    public int? ProcedimientoEnsayoId { get; set; }

    public string Resultado2 { get; set; }

    public string Resultado3 { get; set; }

    public string Resultado4 { get; set; }

    public virtual LabOa Cabecera { get; set; }

    public virtual CtaCentroCoste CentroCoste { get; set; }

    public virtual ICollection<LabOasDetalle> InverseLinea { get; set; } = new List<LabOasDetalle>();

    public virtual IvaTipo IvaTipo { get; set; }

    public virtual ICollection<LabOasLectura> LabOasLecturas { get; set; } = new List<LabOasLectura>();

    public virtual LabOasDetalle Linea { get; set; }

    public virtual MargenesTipo MargenTipo { get; set; }

    public virtual LabProcedimientosEnsayo ProcedimientoEnsayoNavigation { get; set; }

    public virtual Producto ProductoCompuesto { get; set; }
}
