using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class MargenesTipo
{
    /// <summary>
    /// 0: No se aplican Margenes; 1: Se aplica un margen sobre el P. de Compra; 2: se aplica un dto sobre el P. de Venta
    /// </summary>
    public int Idtipo { get; set; }

    public string Nombre { get; set; }

    public string Aplica { get; set; }

    public virtual ICollection<AlbaranesCompraDetalle> AlbaranesCompraDetalles { get; set; } = new List<AlbaranesCompraDetalle>();

    public virtual ICollection<AlbaranesVentaDetalle> AlbaranesVentaDetalles { get; set; } = new List<AlbaranesVentaDetalle>();

    public virtual ICollection<AlqAlquileresDetalle> AlqAlquileresDetalles { get; set; } = new List<AlqAlquileresDetalle>();

    public virtual ICollection<AlqPresupuestosDetalle> AlqPresupuestosDetalles { get; set; } = new List<AlqPresupuestosDetalle>();

    public virtual ICollection<DevolucionesVentaDetalle> DevolucionesVentaDetalles { get; set; } = new List<DevolucionesVentaDetalle>();

    public virtual ICollection<FacturasCompraDetalle> FacturasCompraDetalles { get; set; } = new List<FacturasCompraDetalle>();

    public virtual ICollection<FacturasVentaDetalle> FacturasVentaDetalles { get; set; } = new List<FacturasVentaDetalle>();

    public virtual ICollection<LabBoletinesDetalle> LabBoletinesDetalles { get; set; } = new List<LabBoletinesDetalle>();

    public virtual ICollection<LabOasDetalle> LabOasDetalles { get; set; } = new List<LabOasDetalle>();

    public virtual ICollection<OrdenesFabricacionDetalle> OrdenesFabricacionDetalleMargenTipoIdrealNavigations { get; set; } = new List<OrdenesFabricacionDetalle>();

    public virtual ICollection<OrdenesFabricacionDetalle> OrdenesFabricacionDetalleMargenTipoIdteoricoNavigations { get; set; } = new List<OrdenesFabricacionDetalle>();

    public virtual ICollection<OrdenesSeriadasDetalle> OrdenesSeriadasDetalleMargenTipoIdrealNavigations { get; set; } = new List<OrdenesSeriadasDetalle>();

    public virtual ICollection<OrdenesSeriadasDetalle> OrdenesSeriadasDetalleMargenTipoIdteoricoNavigations { get; set; } = new List<OrdenesSeriadasDetalle>();

    public virtual ICollection<PedidosCompraDetalle> PedidosCompraDetalles { get; set; } = new List<PedidosCompraDetalle>();

    public virtual ICollection<PedidosVentaDetalle> PedidosVentaDetalles { get; set; } = new List<PedidosVentaDetalle>();

    public virtual ICollection<PresupuestosCompraDetalle> PresupuestosCompraDetalles { get; set; } = new List<PresupuestosCompraDetalle>();

    public virtual ICollection<PresupuestosVentaDetalle> PresupuestosVentaDetalles { get; set; } = new List<PresupuestosVentaDetalle>();

    public virtual ICollection<Producto> ProductoMargenCompras { get; set; } = new List<Producto>();

    public virtual ICollection<Producto> ProductoMargenTipos { get; set; } = new List<Producto>();

    public virtual ICollection<ProductosBase> ProductosBases { get; set; } = new List<ProductosBase>();

    public virtual ICollection<ProductosTipo> ProductosTipoDefaultMargenCompras { get; set; } = new List<ProductosTipo>();

    public virtual ICollection<ProductosTipo> ProductosTipoMargenTipos { get; set; } = new List<ProductosTipo>();

    public virtual ICollection<SrvContratosDetalle> SrvContratosDetalles { get; set; } = new List<SrvContratosDetalle>();

    public virtual ICollection<SrvPresupuestosVentaDetalle> SrvPresupuestosVentaDetalles { get; set; } = new List<SrvPresupuestosVentaDetalle>();
}
