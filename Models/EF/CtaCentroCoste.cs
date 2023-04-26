using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class CtaCentroCoste
{
    public int IdcentroCoste { get; set; }

    public int? CentroCosteId { get; set; }

    public int DepartamentoId { get; set; }

    public int? SeccionId { get; set; }

    public string Codigo { get; set; }

    public string Nombre { get; set; }

    public string Descripcion { get; set; }

    public bool? IsDetail { get; set; }

    public virtual ICollection<AlbaranesCompraDetalle> AlbaranesCompraDetalles { get; set; } = new List<AlbaranesCompraDetalle>();

    public virtual ICollection<AlbaranesCompra> AlbaranesCompras { get; set; } = new List<AlbaranesCompra>();

    public virtual ICollection<AlbaranesVentum> AlbaranesVenta { get; set; } = new List<AlbaranesVentum>();

    public virtual ICollection<AlbaranesVentaDetalle> AlbaranesVentaDetalles { get; set; } = new List<AlbaranesVentaDetalle>();

    public virtual ICollection<AlqAlquilere> AlqAlquileres { get; set; } = new List<AlqAlquilere>();

    public virtual ICollection<AlqAlquileresDetalle> AlqAlquileresDetalles { get; set; } = new List<AlqAlquileresDetalle>();

    public virtual ICollection<AlqPresupuesto> AlqPresupuestos { get; set; } = new List<AlqPresupuesto>();

    public virtual ICollection<AlqPresupuestosDetalle> AlqPresupuestosDetalles { get; set; } = new List<AlqPresupuestosDetalle>();

    public virtual ICollection<AsientosDiario> AsientosDiarios { get; set; } = new List<AsientosDiario>();

    public virtual CtaCentroCoste CentroCoste { get; set; }

    public virtual ICollection<Cliente> Clientes { get; set; } = new List<Cliente>();

    public virtual Departamento Departamento { get; set; }

    public virtual ICollection<DevolucionesVentum> DevolucionesVenta { get; set; } = new List<DevolucionesVentum>();

    public virtual ICollection<DevolucionesVentaDetalle> DevolucionesVentaDetalles { get; set; } = new List<DevolucionesVentaDetalle>();

    public virtual ICollection<Diario> Diarios { get; set; } = new List<Diario>();

    public virtual ICollection<FacturasCompraDetalle> FacturasCompraDetalles { get; set; } = new List<FacturasCompraDetalle>();

    public virtual ICollection<FacturasCompra> FacturasCompras { get; set; } = new List<FacturasCompra>();

    public virtual ICollection<FacturasVentum> FacturasVenta { get; set; } = new List<FacturasVentum>();

    public virtual ICollection<FacturasVentaDetalle> FacturasVentaDetalles { get; set; } = new List<FacturasVentaDetalle>();

    public virtual ICollection<Familia> Familia { get; set; } = new List<Familia>();

    public virtual ICollection<CtaCentroCoste> InverseCentroCoste { get; set; } = new List<CtaCentroCoste>();

    public virtual ICollection<LabBoletinesDetalle> LabBoletinesDetalles { get; set; } = new List<LabBoletinesDetalle>();

    public virtual ICollection<LabOasDetalle> LabOasDetalles { get; set; } = new List<LabOasDetalle>();

    public virtual ICollection<Ope> Opes { get; set; } = new List<Ope>();

    public virtual ICollection<OpesDetalle> OpesDetalles { get; set; } = new List<OpesDetalle>();

    public virtual ICollection<PedidosCompraDetalle> PedidosCompraDetalles { get; set; } = new List<PedidosCompraDetalle>();

    public virtual ICollection<PedidosCompra> PedidosCompras { get; set; } = new List<PedidosCompra>();

    public virtual ICollection<PedidosVentum> PedidosVenta { get; set; } = new List<PedidosVentum>();

    public virtual ICollection<PedidosVentaDetalle> PedidosVentaDetalles { get; set; } = new List<PedidosVentaDetalle>();

    public virtual ICollection<PresupuestosCompraDetalle> PresupuestosCompraDetalles { get; set; } = new List<PresupuestosCompraDetalle>();

    public virtual ICollection<PresupuestosCompra> PresupuestosCompras { get; set; } = new List<PresupuestosCompra>();

    public virtual ICollection<PresupuestosVentum> PresupuestosVenta { get; set; } = new List<PresupuestosVentum>();

    public virtual ICollection<PresupuestosVentaDetalle> PresupuestosVentaDetalles { get; set; } = new List<PresupuestosVentaDetalle>();

    public virtual ICollection<Producto> Productos { get; set; } = new List<Producto>();

    public virtual ICollection<ProductosBase> ProductosBases { get; set; } = new List<ProductosBase>();

    public virtual ICollection<Proveedore> Proveedores { get; set; } = new List<Proveedore>();

    public virtual Seccione Seccione { get; set; }

    public virtual ICollection<SrvContrato> SrvContratos { get; set; } = new List<SrvContrato>();

    public virtual ICollection<SrvContratosDetalle> SrvContratosDetalles { get; set; } = new List<SrvContratosDetalle>();

    public virtual ICollection<SrvPresupuestosVentum> SrvPresupuestosVenta { get; set; } = new List<SrvPresupuestosVentum>();

    public virtual ICollection<SrvPresupuestosVentaDetalle> SrvPresupuestosVentaDetalles { get; set; } = new List<SrvPresupuestosVentaDetalle>();
}
