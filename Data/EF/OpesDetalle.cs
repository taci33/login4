using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class OpesDetalle
{
    public int Idlinea { get; set; }

    public long? Idcdbo { get; set; }

    public int CabeceraId { get; set; }

    public int TipoLineaId { get; set; }

    public int? LineaId { get; set; }

    public int? NumLinea { get; set; }

    public int EstadoId { get; set; }

    public int ProductoId { get; set; }

    public int? LoteId { get; set; }

    public string Descripcion { get; set; }

    public string RefPersona { get; set; }

    public double Cantidad { get; set; }

    public double CantidadServida { get; set; }

    public double CantidadPendiente { get; set; }

    public int? MedidaId { get; set; }

    public int? UnidadMedidaId { get; set; }

    public double CantidadPfteorica { get; set; }

    public double CantidadPfreal { get; set; }

    public double CantidadPfrechazada { get; set; }

    public int? OfId { get; set; }

    public int? OfDetalleId { get; set; }

    public int? OsId { get; set; }

    public int? OsDetalleId { get; set; }

    public double Precio { get; set; }

    public decimal BaseImponible { get; set; }

    public int? IvaclaseId { get; set; }

    public bool RecargoEquivalencia { get; set; }

    public int? IvagrupoId { get; set; }

    public string CtaConta { get; set; }

    public DateTime? Fentrega { get; set; }

    public decimal Retencion { get; set; }

    public decimal Total { get; set; }

    public decimal Descuento { get; set; }

    public int? MedidaPfid { get; set; }

    public int? UnidadMedidaPfid { get; set; }

    public int? ProductoPfid { get; set; }

    public int? ConceptoRetencionId { get; set; }

    public int? CentroCosteId { get; set; }

    public int? IvaTipoId { get; set; }

    public bool GestCorte { get; set; }

    public double UnidadesCorte { get; set; }

    public double CantidadX { get; set; }

    public double CantidadY { get; set; }

    public double CantidadZ { get; set; }

    public int? UnidadMedidaIdCorteX { get; set; }

    public int? UnidadMedidaIdCorteY { get; set; }

    public int? UnidadMedidaIdCorteZ { get; set; }

    public double? CantidadXInicial { get; set; }

    public double? CantidadYInicial { get; set; }

    public double? CantidadZInicial { get; set; }

    public double? NumeroCX { get; set; }

    public double? NumeroCY { get; set; }

    public double? NumeroCZ { get; set; }

    public virtual Ope Cabecera { get; set; }

    public virtual CtaCentroCoste CentroCoste { get; set; }

    public virtual ConceptosRetencion ConceptoRetencion { get; set; }

    public virtual OpesEstado Estado { get; set; }

    public virtual OpesDetalleCdbo IdcdboNavigation { get; set; }

    public virtual ICollection<OpesDetalle> InverseLinea { get; set; } = new List<OpesDetalle>();

    public virtual IvaTipo IvaTipo { get; set; }

    public virtual IvaClase Ivaclase { get; set; }

    public virtual Ivagrupo Ivagrupo { get; set; }

    public virtual OpesDetalle Linea { get; set; }

    public virtual Lote Lote { get; set; }

    public virtual Medida Medida { get; set; }

    public virtual Medida MedidaPf { get; set; }

    public virtual OrdenesFabricacion Of { get; set; }

    public virtual OrdenesSeriada Os { get; set; }

    public virtual Producto Producto { get; set; }

    public virtual Producto ProductoPf { get; set; }

    public virtual TiposLinea TipoLinea { get; set; }

    public virtual UnidadesMedidum UnidadMedida { get; set; }

    public virtual UnidadesMedidum UnidadMedidaIdCorteXNavigation { get; set; }

    public virtual UnidadesMedidum UnidadMedidaIdCorteYNavigation { get; set; }

    public virtual UnidadesMedidum UnidadMedidaIdCorteZNavigation { get; set; }

    public virtual UnidadesMedidum UnidadMedidaPf { get; set; }
}
