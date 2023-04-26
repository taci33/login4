using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class FacturasCompraDetalle
{
    public int Idlinea { get; set; }

    public long? Idcdbo { get; set; }

    public int CabeceraId { get; set; }

    public int? LineaId { get; set; }

    public int TipoLineaId { get; set; }

    public int EstadoId { get; set; }

    public int ProductoId { get; set; }

    public int? MedidaId { get; set; }

    public int? UnidadMedidaId { get; set; }

    public int? IvaClaseId { get; set; }

    public decimal Descuento { get; set; }

    public int? NumLinea { get; set; }

    public string Descripcion { get; set; }

    public double Cantidad { get; set; }

    public double CantidadServida { get; set; }

    public double CantidadPendiente { get; set; }

    public double Precio { get; set; }

    public decimal BaseImponible { get; set; }

    public decimal Total { get; set; }

    public string CtaConta { get; set; }

    public decimal? PorcentajeRet { get; set; }

    public decimal? ImporteRet { get; set; }

    public string CtaRet { get; set; }

    public int? IvagrupoId { get; set; }

    public string RefPersona { get; set; }

    public int LoteId { get; set; }

    public decimal Retencion { get; set; }

    public bool RecargoEquivalencia { get; set; }

    public string CodigoPropioProducto { get; set; }

    public string NumeroLote { get; set; }

    public DateTime? Fentrega { get; set; }

    public Guid? UidId { get; set; }

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

    public int MargenTipoId { get; set; }

    public decimal Margen { get; set; }

    public double PrecioVentaProducto { get; set; }

    public double CantidadUnitaria { get; set; }

    public double? CantidadXInicial { get; set; }

    public double? CantidadYInicial { get; set; }

    public double? CantidadZInicial { get; set; }

    public double? NumeroCX { get; set; }

    public double? NumeroCY { get; set; }

    public double? NumeroCZ { get; set; }

    public virtual ICollection<BienesAmortizable> BienesAmortizables { get; set; } = new List<BienesAmortizable>();

    public virtual FacturasCompra Cabecera { get; set; }

    public virtual CtaCentroCoste CentroCoste { get; set; }

    public virtual ConceptosRetencion ConceptoRetencion { get; set; }

    public virtual FacturasCompraEstado Estado { get; set; }

    public virtual FacturasCompraDetalleCdbo IdcdboNavigation { get; set; }

    public virtual IvaClase IvaClase { get; set; }

    public virtual IvaTipo IvaTipo { get; set; }

    public virtual Ivagrupo Ivagrupo { get; set; }

    public virtual MargenesTipo MargenTipo { get; set; }

    public virtual Medida Medida { get; set; }

    public virtual Producto Producto { get; set; }

    public virtual TiposLinea TipoLinea { get; set; }

    public virtual UnidadesMedidum UnidadMedida { get; set; }

    public virtual UnidadesMedidum UnidadMedidaIdCorteXNavigation { get; set; }

    public virtual UnidadesMedidum UnidadMedidaIdCorteYNavigation { get; set; }

    public virtual UnidadesMedidum UnidadMedidaIdCorteZNavigation { get; set; }
}
