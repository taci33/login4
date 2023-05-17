using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class UnidadesMedidum
{
    public int IdunidadMedida { get; set; }

    public int MedidaId { get; set; }

    public double Escala { get; set; }

    public string Nombre { get; set; }

    public string Abreviatura { get; set; }

    public virtual ICollection<AgenciasTransporteTarifasDetalle> AgenciasTransporteTarifasDetalles { get; set; } = new List<AgenciasTransporteTarifasDetalle>();

    public virtual ICollection<AlbaranesCompraDetalle> AlbaranesCompraDetalleUnidadMedida { get; set; } = new List<AlbaranesCompraDetalle>();

    public virtual ICollection<AlbaranesCompraDetalle> AlbaranesCompraDetalleUnidadMedidaIdCorteXNavigations { get; set; } = new List<AlbaranesCompraDetalle>();

    public virtual ICollection<AlbaranesCompraDetalle> AlbaranesCompraDetalleUnidadMedidaIdCorteYNavigations { get; set; } = new List<AlbaranesCompraDetalle>();

    public virtual ICollection<AlbaranesCompraDetalle> AlbaranesCompraDetalleUnidadMedidaIdCorteZNavigations { get; set; } = new List<AlbaranesCompraDetalle>();

    public virtual ICollection<AlbaranesVentaDetalle> AlbaranesVentaDetalleUnidadMedida { get; set; } = new List<AlbaranesVentaDetalle>();

    public virtual ICollection<AlbaranesVentaDetalle> AlbaranesVentaDetalleUnidadMedidaIdCorteXNavigations { get; set; } = new List<AlbaranesVentaDetalle>();

    public virtual ICollection<AlbaranesVentaDetalle> AlbaranesVentaDetalleUnidadMedidaIdCorteYNavigations { get; set; } = new List<AlbaranesVentaDetalle>();

    public virtual ICollection<AlbaranesVentaDetalle> AlbaranesVentaDetalleUnidadMedidaIdCorteZNavigations { get; set; } = new List<AlbaranesVentaDetalle>();

    public virtual ICollection<AlqAlquileresDetalle> AlqAlquileresDetalles { get; set; } = new List<AlqAlquileresDetalle>();

    public virtual ICollection<AlqPresupuestosDetalle> AlqPresupuestosDetalles { get; set; } = new List<AlqPresupuestosDetalle>();

    public virtual ICollection<ComisionesDetalle> ComisionesDetalles { get; set; } = new List<ComisionesDetalle>();

    public virtual ICollection<DevolucionesVentaDetalle> DevolucionesVentaDetalleUnidadMedida { get; set; } = new List<DevolucionesVentaDetalle>();

    public virtual ICollection<DevolucionesVentaDetalle> DevolucionesVentaDetalleUnidadMedidaIdCorteXNavigations { get; set; } = new List<DevolucionesVentaDetalle>();

    public virtual ICollection<DevolucionesVentaDetalle> DevolucionesVentaDetalleUnidadMedidaIdCorteYNavigations { get; set; } = new List<DevolucionesVentaDetalle>();

    public virtual ICollection<DevolucionesVentaDetalle> DevolucionesVentaDetalleUnidadMedidaIdCorteZNavigations { get; set; } = new List<DevolucionesVentaDetalle>();

    public virtual ICollection<DgdUbicacione> DgdUbicaciones { get; set; } = new List<DgdUbicacione>();

    public virtual ICollection<DocumentosGestionDetalleUbicacione> DocumentosGestionDetalleUbicaciones { get; set; } = new List<DocumentosGestionDetalleUbicacione>();

    public virtual ICollection<FacturasCompraDetalle> FacturasCompraDetalleUnidadMedida { get; set; } = new List<FacturasCompraDetalle>();

    public virtual ICollection<FacturasCompraDetalle> FacturasCompraDetalleUnidadMedidaIdCorteXNavigations { get; set; } = new List<FacturasCompraDetalle>();

    public virtual ICollection<FacturasCompraDetalle> FacturasCompraDetalleUnidadMedidaIdCorteYNavigations { get; set; } = new List<FacturasCompraDetalle>();

    public virtual ICollection<FacturasCompraDetalle> FacturasCompraDetalleUnidadMedidaIdCorteZNavigations { get; set; } = new List<FacturasCompraDetalle>();

    public virtual ICollection<FacturasVentaDetalle> FacturasVentaDetalleUnidadMedida { get; set; } = new List<FacturasVentaDetalle>();

    public virtual ICollection<FacturasVentaDetalle> FacturasVentaDetalleUnidadMedidaIdCorteXNavigations { get; set; } = new List<FacturasVentaDetalle>();

    public virtual ICollection<FacturasVentaDetalle> FacturasVentaDetalleUnidadMedidaIdCorteYNavigations { get; set; } = new List<FacturasVentaDetalle>();

    public virtual ICollection<FacturasVentaDetalle> FacturasVentaDetalleUnidadMedidaIdCorteZNavigations { get; set; } = new List<FacturasVentaDetalle>();

    public virtual ICollection<LabBoletinesDetalle> LabBoletinesDetalles { get; set; } = new List<LabBoletinesDetalle>();

    public virtual ICollection<LiquidacionesComercialDetalle> LiquidacionesComercialDetalles { get; set; } = new List<LiquidacionesComercialDetalle>();

    public virtual Medida Medida { get; set; }

    public virtual ICollection<MovimientosAlmacenDetalle> MovimientosAlmacenDetalles { get; set; } = new List<MovimientosAlmacenDetalle>();

    public virtual ICollection<OpesDetalle> OpesDetalleUnidadMedida { get; set; } = new List<OpesDetalle>();

    public virtual ICollection<OpesDetalle> OpesDetalleUnidadMedidaIdCorteXNavigations { get; set; } = new List<OpesDetalle>();

    public virtual ICollection<OpesDetalle> OpesDetalleUnidadMedidaIdCorteYNavigations { get; set; } = new List<OpesDetalle>();

    public virtual ICollection<OpesDetalle> OpesDetalleUnidadMedidaIdCorteZNavigations { get; set; } = new List<OpesDetalle>();

    public virtual ICollection<OpesDetalle> OpesDetalleUnidadMedidaPfs { get; set; } = new List<OpesDetalle>();

    public virtual ICollection<OrdenesFabricacionDetalle> OrdenesFabricacionDetalleUnidadMedida { get; set; } = new List<OrdenesFabricacionDetalle>();

    public virtual ICollection<OrdenesFabricacionDetalle> OrdenesFabricacionDetalleUnidadMedidaIdCorteXNavigations { get; set; } = new List<OrdenesFabricacionDetalle>();

    public virtual ICollection<OrdenesFabricacionDetalle> OrdenesFabricacionDetalleUnidadMedidaIdCorteYNavigations { get; set; } = new List<OrdenesFabricacionDetalle>();

    public virtual ICollection<OrdenesFabricacionDetalle> OrdenesFabricacionDetalleUnidadMedidaIdCorteZNavigations { get; set; } = new List<OrdenesFabricacionDetalle>();

    public virtual ICollection<OrdenesSeriada> OrdenesSeriada { get; set; } = new List<OrdenesSeriada>();

    public virtual ICollection<OrdenesSeriadasDetalle> OrdenesSeriadasDetalleUnidadMedida { get; set; } = new List<OrdenesSeriadasDetalle>();

    public virtual ICollection<OrdenesSeriadasDetalle> OrdenesSeriadasDetalleUnidadMedidaPfs { get; set; } = new List<OrdenesSeriadasDetalle>();

    public virtual ICollection<Parte> ParteUnidadMedidaIdCorteXNavigations { get; set; } = new List<Parte>();

    public virtual ICollection<Parte> ParteUnidadMedidaIdCorteYNavigations { get; set; } = new List<Parte>();

    public virtual ICollection<Parte> ParteUnidadMedidaIdCorteZNavigations { get; set; } = new List<Parte>();

    public virtual ICollection<Parte> ParteUnidadesMedida { get; set; } = new List<Parte>();

    public virtual ICollection<Parte> ParteUnidadesMedidumNavigations { get; set; } = new List<Parte>();

    public virtual ICollection<PedidosCompraDetalle> PedidosCompraDetalleUnidadMedida { get; set; } = new List<PedidosCompraDetalle>();

    public virtual ICollection<PedidosCompraDetalle> PedidosCompraDetalleUnidadMedidaIdCorteXNavigations { get; set; } = new List<PedidosCompraDetalle>();

    public virtual ICollection<PedidosCompraDetalle> PedidosCompraDetalleUnidadMedidaIdCorteYNavigations { get; set; } = new List<PedidosCompraDetalle>();

    public virtual ICollection<PedidosCompraDetalle> PedidosCompraDetalleUnidadMedidaIdCorteZNavigations { get; set; } = new List<PedidosCompraDetalle>();

    public virtual ICollection<PedidosVentaDetalle> PedidosVentaDetalleUnidadMedida { get; set; } = new List<PedidosVentaDetalle>();

    public virtual ICollection<PedidosVentaDetalle> PedidosVentaDetalleUnidadMedidaIdCorteXNavigations { get; set; } = new List<PedidosVentaDetalle>();

    public virtual ICollection<PedidosVentaDetalle> PedidosVentaDetalleUnidadMedidaIdCorteYNavigations { get; set; } = new List<PedidosVentaDetalle>();

    public virtual ICollection<PedidosVentaDetalle> PedidosVentaDetalleUnidadMedidaIdCorteZNavigations { get; set; } = new List<PedidosVentaDetalle>();

    public virtual ICollection<PresupuestosCompraDetalle> PresupuestosCompraDetalleUnidadMedida { get; set; } = new List<PresupuestosCompraDetalle>();

    public virtual ICollection<PresupuestosCompraDetalle> PresupuestosCompraDetalleUnidadMedidaIdCorteXNavigations { get; set; } = new List<PresupuestosCompraDetalle>();

    public virtual ICollection<PresupuestosCompraDetalle> PresupuestosCompraDetalleUnidadMedidaIdCorteYNavigations { get; set; } = new List<PresupuestosCompraDetalle>();

    public virtual ICollection<PresupuestosCompraDetalle> PresupuestosCompraDetalleUnidadMedidaIdCorteZNavigations { get; set; } = new List<PresupuestosCompraDetalle>();

    public virtual ICollection<PresupuestosVentaDetalle> PresupuestosVentaDetalleUnidadMedida { get; set; } = new List<PresupuestosVentaDetalle>();

    public virtual ICollection<PresupuestosVentaDetalle> PresupuestosVentaDetalleUnidadMedidaIdCorteXNavigations { get; set; } = new List<PresupuestosVentaDetalle>();

    public virtual ICollection<PresupuestosVentaDetalle> PresupuestosVentaDetalleUnidadMedidaIdCorteYNavigations { get; set; } = new List<PresupuestosVentaDetalle>();

    public virtual ICollection<PresupuestosVentaDetalle> PresupuestosVentaDetalleUnidadMedidaIdCorteZNavigations { get; set; } = new List<PresupuestosVentaDetalle>();

    public virtual ICollection<Producto> ProductoUnidadMedidaIdCorteXNavigations { get; set; } = new List<Producto>();

    public virtual ICollection<Producto> ProductoUnidadMedidaIdCorteYNavigations { get; set; } = new List<Producto>();

    public virtual ICollection<Producto> ProductoUnidadMedidaIdCorteZNavigations { get; set; } = new List<Producto>();

    public virtual ICollection<Producto> ProductoUnidadesMedida { get; set; } = new List<Producto>();

    public virtual ICollection<ProductosCodigosBarra> ProductosCodigosBarras { get; set; } = new List<ProductosCodigosBarra>();

    public virtual ICollection<ProductosCompuesto> ProductosCompuestos { get; set; } = new List<ProductosCompuesto>();

    public virtual ICollection<ProductosConjunto> ProductosConjuntos { get; set; } = new List<ProductosConjunto>();

    public virtual ICollection<ProductosConjuntosComponente> ProductosConjuntosComponentes { get; set; } = new List<ProductosConjuntosComponente>();

    public virtual ICollection<ProductosTipo> ProductosTipos { get; set; } = new List<ProductosTipo>();

    public virtual ICollection<PropuestasCompraDetalle> PropuestasCompraDetalles { get; set; } = new List<PropuestasCompraDetalle>();

    public virtual ICollection<RegularizacionesAlmacen> RegularizacionesAlmacens { get; set; } = new List<RegularizacionesAlmacen>();

    public virtual ICollection<SrvContratosDetalle> SrvContratosDetalleUnidadMedida { get; set; } = new List<SrvContratosDetalle>();

    public virtual ICollection<SrvContratosDetalle> SrvContratosDetalleUnidadMedidaIdCorteXNavigations { get; set; } = new List<SrvContratosDetalle>();

    public virtual ICollection<SrvContratosDetalle> SrvContratosDetalleUnidadMedidaIdCorteYNavigations { get; set; } = new List<SrvContratosDetalle>();

    public virtual ICollection<SrvContratosDetalle> SrvContratosDetalleUnidadMedidaIdCorteZNavigations { get; set; } = new List<SrvContratosDetalle>();

    public virtual ICollection<SrvPresupuestosVentaDetalle> SrvPresupuestosVentaDetalleUnidadMedida { get; set; } = new List<SrvPresupuestosVentaDetalle>();

    public virtual ICollection<SrvPresupuestosVentaDetalle> SrvPresupuestosVentaDetalleUnidadMedidaIdCorteXNavigations { get; set; } = new List<SrvPresupuestosVentaDetalle>();

    public virtual ICollection<SrvPresupuestosVentaDetalle> SrvPresupuestosVentaDetalleUnidadMedidaIdCorteYNavigations { get; set; } = new List<SrvPresupuestosVentaDetalle>();

    public virtual ICollection<SrvPresupuestosVentaDetalle> SrvPresupuestosVentaDetalleUnidadMedidaIdCorteZNavigations { get; set; } = new List<SrvPresupuestosVentaDetalle>();

    public virtual ICollection<TpvticketsDetalle> TpvticketsDetalles { get; set; } = new List<TpvticketsDetalle>();

    public virtual ICollection<UnidadesProductoBase> UnidadesProductoBases { get; set; } = new List<UnidadesProductoBase>();

    public virtual ICollection<UnidadesProducto> UnidadesProductos { get; set; } = new List<UnidadesProducto>();
}
