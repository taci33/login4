using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class Medida
{
    public int Idmedida { get; set; }

    public string Nombre { get; set; }

    public int NdimCorte { get; set; }

    public virtual ICollection<AlbaranesCompraDetalle> AlbaranesCompraDetalles { get; set; } = new List<AlbaranesCompraDetalle>();

    public virtual ICollection<AlbaranesVentaDetalle> AlbaranesVentaDetalles { get; set; } = new List<AlbaranesVentaDetalle>();

    public virtual ICollection<AlqAlquileresDetalle> AlqAlquileresDetalles { get; set; } = new List<AlqAlquileresDetalle>();

    public virtual ICollection<AlqPresupuestosDetalle> AlqPresupuestosDetalles { get; set; } = new List<AlqPresupuestosDetalle>();

    public virtual ICollection<DevolucionesVentaDetalle> DevolucionesVentaDetalles { get; set; } = new List<DevolucionesVentaDetalle>();

    public virtual ICollection<DgdUbicacione> DgdUbicaciones { get; set; } = new List<DgdUbicacione>();

    public virtual ICollection<DocumentosGestionDetalleUbicacione> DocumentosGestionDetalleUbicaciones { get; set; } = new List<DocumentosGestionDetalleUbicacione>();

    public virtual ICollection<FacturasCompraDetalle> FacturasCompraDetalles { get; set; } = new List<FacturasCompraDetalle>();

    public virtual ICollection<FacturasVentaDetalle> FacturasVentaDetalles { get; set; } = new List<FacturasVentaDetalle>();

    public virtual ICollection<LabBoletinesDetalle> LabBoletinesDetalles { get; set; } = new List<LabBoletinesDetalle>();

    public virtual ICollection<OpesDetalle> OpesDetalleMedida { get; set; } = new List<OpesDetalle>();

    public virtual ICollection<OpesDetalle> OpesDetalleMedidaPfs { get; set; } = new List<OpesDetalle>();

    public virtual ICollection<OrdenesFabricacionDetalle> OrdenesFabricacionDetalles { get; set; } = new List<OrdenesFabricacionDetalle>();

    public virtual ICollection<OrdenesSeriada> OrdenesSeriada { get; set; } = new List<OrdenesSeriada>();

    public virtual ICollection<OrdenesSeriadasDetalle> OrdenesSeriadasDetalleMedida { get; set; } = new List<OrdenesSeriadasDetalle>();

    public virtual ICollection<OrdenesSeriadasDetalle> OrdenesSeriadasDetalleMedidaPfs { get; set; } = new List<OrdenesSeriadasDetalle>();

    public virtual ICollection<PedidosCompraDetalle> PedidosCompraDetalles { get; set; } = new List<PedidosCompraDetalle>();

    public virtual ICollection<PedidosVentaDetalle> PedidosVentaDetalles { get; set; } = new List<PedidosVentaDetalle>();

    public virtual ICollection<PresupuestosCompraDetalle> PresupuestosCompraDetalles { get; set; } = new List<PresupuestosCompraDetalle>();

    public virtual ICollection<PresupuestosVentaDetalle> PresupuestosVentaDetalles { get; set; } = new List<PresupuestosVentaDetalle>();

    public virtual ICollection<Producto> Productos { get; set; } = new List<Producto>();

    public virtual ICollection<RegularizacionesAlmacen> RegularizacionesAlmacens { get; set; } = new List<RegularizacionesAlmacen>();

    public virtual ICollection<SrvContratosDetalle> SrvContratosDetalles { get; set; } = new List<SrvContratosDetalle>();

    public virtual ICollection<SrvPresupuestosVentaDetalle> SrvPresupuestosVentaDetalles { get; set; } = new List<SrvPresupuestosVentaDetalle>();

    public virtual ICollection<UnidadesMedidum> UnidadesMedida { get; set; } = new List<UnidadesMedidum>();

    public virtual ICollection<UnidadesProductoBase> UnidadesProductoBases { get; set; } = new List<UnidadesProductoBase>();

    public virtual ICollection<UnidadesProducto> UnidadesProductos { get; set; } = new List<UnidadesProducto>();
}
