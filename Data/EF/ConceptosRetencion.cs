using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class ConceptosRetencion
{
    public int IdconceptoRetencion { get; set; }

    public string Concepto { get; set; }

    public decimal Retencion { get; set; }

    public string CtaCompras { get; set; }

    public string CtaVentas { get; set; }

    public virtual ICollection<AlbaranesCompraDetalle> AlbaranesCompraDetalles { get; set; } = new List<AlbaranesCompraDetalle>();

    public virtual ICollection<AlbaranesVentaDetalle> AlbaranesVentaDetalles { get; set; } = new List<AlbaranesVentaDetalle>();

    public virtual ICollection<AlqAlquileresDetalle> AlqAlquileresDetalles { get; set; } = new List<AlqAlquileresDetalle>();

    public virtual ICollection<AlqPresupuestosDetalle> AlqPresupuestosDetalles { get; set; } = new List<AlqPresupuestosDetalle>();

    public virtual ICollection<Cliente> Clientes { get; set; } = new List<Cliente>();

    public virtual Pgc CtaComprasNavigation { get; set; }

    public virtual Pgc CtaVentasNavigation { get; set; }

    public virtual ICollection<DevolucionesVentaDetalle> DevolucionesVentaDetalles { get; set; } = new List<DevolucionesVentaDetalle>();

    public virtual ICollection<FacturasCompraDetalle> FacturasCompraDetalles { get; set; } = new List<FacturasCompraDetalle>();

    public virtual ICollection<FacturasVentaDetalle> FacturasVentaDetalles { get; set; } = new List<FacturasVentaDetalle>();

    public virtual ICollection<LabBoletinesDetalle> LabBoletinesDetalles { get; set; } = new List<LabBoletinesDetalle>();

    public virtual ICollection<OpesDetalle> OpesDetalles { get; set; } = new List<OpesDetalle>();

    public virtual ICollection<PedidosCompraDetalle> PedidosCompraDetalles { get; set; } = new List<PedidosCompraDetalle>();

    public virtual ICollection<PedidosVentaDetalle> PedidosVentaDetalles { get; set; } = new List<PedidosVentaDetalle>();

    public virtual ICollection<PresupuestosCompraDetalle> PresupuestosCompraDetalles { get; set; } = new List<PresupuestosCompraDetalle>();

    public virtual ICollection<PresupuestosVentaDetalle> PresupuestosVentaDetalles { get; set; } = new List<PresupuestosVentaDetalle>();

    public virtual ICollection<Producto> Productos { get; set; } = new List<Producto>();

    public virtual ICollection<Proveedore> Proveedores { get; set; } = new List<Proveedore>();

    public virtual ICollection<SrvContratosDetalle> SrvContratosDetalles { get; set; } = new List<SrvContratosDetalle>();

    public virtual ICollection<SrvPresupuestosVentaDetalle> SrvPresupuestosVentaDetalles { get; set; } = new List<SrvPresupuestosVentaDetalle>();
}
