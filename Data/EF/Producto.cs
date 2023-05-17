using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class Producto
{
    public int Idproducto { get; set; }

    public long? Idcdbo { get; set; }

    public int? ProductoBaseId { get; set; }

    public int? EmpresaId { get; set; }

    public int? FamiliaId { get; set; }

    public int? MarcaId { get; set; }

    public int ProductoTipoId { get; set; }

    public int ProductoEstadoId { get; set; }

    public string ReferenciaProveedor { get; set; }

    public string CodigoBarras { get; set; }

    public string CodigoPropio { get; set; }

    public string Nombre { get; set; }

    public string Descripcion { get; set; }

    public DateTime Falta { get; set; }

    public DateTime? Fbaja { get; set; }

    public double StockMin { get; set; }

    public double StockMax { get; set; }

    public double StockActual { get; set; }

    public double StockPedido { get; set; }

    public bool StockNegativo { get; set; }

    public double PrecioCompra { get; set; }

    public double PrecioCompraMedio { get; set; }

    public double PrecioVenta { get; set; }

    public double PrecioVentaMedio { get; set; }

    public string Notas { get; set; }

    public bool GestLotes { get; set; }

    public bool? GestStock { get; set; }

    public bool GestAlmacen { get; set; }

    public bool GestMargen { get; set; }

    public double? Margen { get; set; }

    public bool TarifaDiaria { get; set; }

    public int IvaclaseId { get; set; }

    public int? TemporadaId { get; set; }

    public string CtaCompras { get; set; }

    public string CtaVentas { get; set; }

    public int Dbstate { get; set; }

    public double Pvp { get; set; }

    public int? CentroCosteId { get; set; }

    public double? DescuentoMaximo { get; set; }

    public int MargenTipoId { get; set; }

    public bool GestCorte { get; set; }

    public int? MedidaIdCorte { get; set; }

    public int? UnidadMedidaIdCorte { get; set; }

    public int? UnidadMedidaIdCorteX { get; set; }

    public int? UnidadMedidaIdCorteY { get; set; }

    public int? UnidadMedidaIdCorteZ { get; set; }

    public double Multiplicador { get; set; }

    public bool GestPreciosLotes { get; set; }

    public bool InstalacionRequired { get; set; }

    public int? ConceptoRetencionId { get; set; }

    public int MargenCompraId { get; set; }

    public double PrecioCompraSugerido { get; set; }

    public double? DtoCompraSugerido { get; set; }

    public double PrecioCompraSinDtoSugerido { get; set; }

    public int? ProductoCompuestoPlantillaId { get; set; }

    public double StockWeb { get; set; }

    public double StockDisponible { get; set; }

    public double StockVirtual { get; set; }

    public double StockReservado { get; set; }

    public double? DtoCompraUltima { get; set; }

    public double PrecioCompraSinDtoUltima { get; set; }

    public double StockPendienteRecibir { get; set; }

    public string AbreviaturaLote { get; set; }

    public int? TiempoCaducidad { get; set; }

    public double StockPendienteServir { get; set; }

    public bool GestCorteMultiplos { get; set; }

    public bool GestCorteNumero { get; set; }

    public int MultiploCorteX { get; set; }

    public int MultiploCorteY { get; set; }

    public int MultiploCorteZ { get; set; }

    public double LoteMinCompra { get; set; }

    public double LoteMinVenta { get; set; }

    public int? EmpleadoResponsableId { get; set; }

    public virtual ICollection<AlbaranesCompraDetalle> AlbaranesCompraDetalles { get; set; } = new List<AlbaranesCompraDetalle>();

    public virtual ICollection<AlbaranesVentaDetalle> AlbaranesVentaDetalles { get; set; } = new List<AlbaranesVentaDetalle>();

    public virtual ICollection<AlqAlquileresDetalle> AlqAlquileresDetalles { get; set; } = new List<AlqAlquileresDetalle>();

    public virtual ICollection<AlqPresupuestosDetalle> AlqPresupuestosDetalles { get; set; } = new List<AlqPresupuestosDetalle>();

    public virtual ICollection<BienesAmortizable> BienesAmortizables { get; set; } = new List<BienesAmortizable>();

    public virtual CtaCentroCoste CentroCoste { get; set; }

    public virtual ICollection<ComisionesDetalle> ComisionesDetalles { get; set; } = new List<ComisionesDetalle>();

    public virtual ConceptosRetencion ConceptoRetencion { get; set; }

    public virtual ICollection<CrmPuntosTablaDetalle> CrmPuntosTablaDetalles { get; set; } = new List<CrmPuntosTablaDetalle>();

    public virtual ICollection<DevolucionesVentaDetalle> DevolucionesVentaDetalles { get; set; } = new List<DevolucionesVentaDetalle>();

    public virtual ICollection<DgdUbicacione> DgdUbicaciones { get; set; } = new List<DgdUbicacione>();

    public virtual ICollection<DocumentosGestionDetalleUbicacione> DocumentosGestionDetalleUbicaciones { get; set; } = new List<DocumentosGestionDetalleUbicacione>();

    public virtual Empleado EmpleadoResponsable { get; set; }

    public virtual ICollection<FacturasCompraDetalle> FacturasCompraDetalles { get; set; } = new List<FacturasCompraDetalle>();

    public virtual ICollection<FacturasVentaDetalle> FacturasVentaDetalles { get; set; } = new List<FacturasVentaDetalle>();

    public virtual Familia Familia { get; set; }

    public virtual ICollection<FasesCentro> FasesCentros { get; set; } = new List<FasesCentro>();

    public virtual ProductosCdbo IdcdboNavigation { get; set; }

    public virtual ICollection<IsoMantenimientosDetalle> IsoMantenimientosDetalles { get; set; } = new List<IsoMantenimientosDetalle>();

    public virtual IsoProducto IsoProducto { get; set; }

    public virtual IvaClase Ivaclase { get; set; }

    public virtual ICollection<LabBoletinesDetalle> LabBoletinesDetalleProductoCompuestos { get; set; } = new List<LabBoletinesDetalle>();

    public virtual ICollection<LabBoletinesDetalle> LabBoletinesDetalleProductos { get; set; } = new List<LabBoletinesDetalle>();

    public virtual ICollection<LabOa> LabOas { get; set; } = new List<LabOa>();

    public virtual ICollection<LabOasDetalle> LabOasDetalles { get; set; } = new List<LabOasDetalle>();

    public virtual ICollection<LiquidacionesComercialDetalle> LiquidacionesComercialDetalles { get; set; } = new List<LiquidacionesComercialDetalle>();

    public virtual ICollection<Lote> Lotes { get; set; } = new List<Lote>();

    public virtual Marca Marca { get; set; }

    public virtual MargenesTipo MargenCompra { get; set; }

    public virtual MargenesTipo MargenTipo { get; set; }

    public virtual Medida MedidaIdCorteNavigation { get; set; }

    public virtual ICollection<MovimientosAlmacenDetalle> MovimientosAlmacenDetalles { get; set; } = new List<MovimientosAlmacenDetalle>();

    public virtual ICollection<MovimientosAlmacenSaldo> MovimientosAlmacenSaldos { get; set; } = new List<MovimientosAlmacenSaldo>();

    public virtual ICollection<OpesDetalle> OpesDetalleProductoPfs { get; set; } = new List<OpesDetalle>();

    public virtual ICollection<OpesDetalle> OpesDetalleProductos { get; set; } = new List<OpesDetalle>();

    public virtual ICollection<OrdenesFabricacionDetalle> OrdenesFabricacionDetalles { get; set; } = new List<OrdenesFabricacionDetalle>();

    public virtual ICollection<OrdenesSeriadasDetalle> OrdenesSeriadasDetalles { get; set; } = new List<OrdenesSeriadasDetalle>();

    public virtual ICollection<Parte> Partes { get; set; } = new List<Parte>();

    public virtual ICollection<PedidosCompraDetalle> PedidosCompraDetalles { get; set; } = new List<PedidosCompraDetalle>();

    public virtual ICollection<PedidosVentaDetalle> PedidosVentaDetalles { get; set; } = new List<PedidosVentaDetalle>();

    public virtual ICollection<PresupuestosCompraDetalle> PresupuestosCompraDetalles { get; set; } = new List<PresupuestosCompraDetalle>();

    public virtual ICollection<PresupuestosVentaDetalleCdbo> PresupuestosVentaDetalleCdbos { get; set; } = new List<PresupuestosVentaDetalleCdbo>();

    public virtual ICollection<PresupuestosVentaDetalle> PresupuestosVentaDetalles { get; set; } = new List<PresupuestosVentaDetalle>();

    public virtual ICollection<PresupuestosVentaProductosActualizable> PresupuestosVentaProductosActualizables { get; set; } = new List<PresupuestosVentaProductosActualizable>();

    public virtual ProductosBase ProductoBase { get; set; }

    public virtual ProductosEstado ProductoEstado { get; set; }

    public virtual ProductosTipo ProductoTipo { get; set; }

    public virtual ICollection<ProductosAlmacen> ProductosAlmacens { get; set; } = new List<ProductosAlmacen>();

    public virtual ICollection<ProductosAtribsValore> ProductosAtribsValores { get; set; } = new List<ProductosAtribsValore>();

    public virtual ICollection<ProductosCliente> ProductosClientes { get; set; } = new List<ProductosCliente>();

    public virtual ICollection<ProductosCompuesto> ProductosCompuestoProductoCompuestos { get; set; } = new List<ProductosCompuesto>();

    public virtual ICollection<ProductosCompuesto> ProductosCompuestoProductos { get; set; } = new List<ProductosCompuesto>();

    public virtual ICollection<ProductosCompuestosPlantillasLog> ProductosCompuestosPlantillasLogs { get; set; } = new List<ProductosCompuestosPlantillasLog>();

    public virtual ICollection<ProductosDatosDinamico> ProductosDatosDinamicos { get; set; } = new List<ProductosDatosDinamico>();

    public virtual ICollection<ProductosSugerido> ProductosSugeridoProductoSugeridos { get; set; } = new List<ProductosSugerido>();

    public virtual ICollection<ProductosSugerido> ProductosSugeridoProductos { get; set; } = new List<ProductosSugerido>();

    public virtual ICollection<PropuestasCompraDetalle> PropuestasCompraDetalles { get; set; } = new List<PropuestasCompraDetalle>();

    public virtual ICollection<Proyecto> Proyectos { get; set; } = new List<Proyecto>();

    public virtual ICollection<RegularizacionesAlmacen> RegularizacionesAlmacens { get; set; } = new List<RegularizacionesAlmacen>();

    public virtual ICollection<ReservasStockDetalle> ReservasStockDetalles { get; set; } = new List<ReservasStockDetalle>();

    public virtual ICollection<SrvContratosDetalle> SrvContratosDetalles { get; set; } = new List<SrvContratosDetalle>();

    public virtual ICollection<SrvPresupuestosVentaDetalle> SrvPresupuestosVentaDetalles { get; set; } = new List<SrvPresupuestosVentaDetalle>();

    public virtual ICollection<TarifasDetalle> TarifasDetalles { get; set; } = new List<TarifasDetalle>();

    public virtual ICollection<TpvticketsDetalle> TpvticketsDetalles { get; set; } = new List<TpvticketsDetalle>();

    public virtual UnidadesMedidum UnidadMedidaIdCorteXNavigation { get; set; }

    public virtual UnidadesMedidum UnidadMedidaIdCorteYNavigation { get; set; }

    public virtual UnidadesMedidum UnidadMedidaIdCorteZNavigation { get; set; }

    public virtual UnidadesMedidum UnidadesMedidum { get; set; }

    public virtual ICollection<UnidadesProducto> UnidadesProductos { get; set; } = new List<UnidadesProducto>();

    public virtual ICollection<Vale> Vales { get; set; } = new List<Vale>();

    public virtual ICollection<IsoRequisito> Requisitos { get; set; } = new List<IsoRequisito>();
}
