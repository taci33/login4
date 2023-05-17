using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class MediosPago
{
    public int IdmedioPago { get; set; }

    public string Nombre { get; set; }

    public bool Remesable { get; set; }

    public int CargoCuentaId { get; set; }

    public int? CuentaEmpresaId { get; set; }

    public virtual ICollection<AlbaranesCompra> AlbaranesCompras { get; set; } = new List<AlbaranesCompra>();

    public virtual ICollection<AlbaranesVentum> AlbaranesVenta { get; set; } = new List<AlbaranesVentum>();

    public virtual ICollection<AlbaranesVentaAnticipo> AlbaranesVentaAnticipos { get; set; } = new List<AlbaranesVentaAnticipo>();

    public virtual ICollection<AlqAlquilere> AlqAlquileres { get; set; } = new List<AlqAlquilere>();

    public virtual ICollection<AlqPresupuesto> AlqPresupuestos { get; set; } = new List<AlqPresupuesto>();

    public virtual MediosPagoCargoCuentum CargoCuenta { get; set; }

    public virtual ICollection<Certificacione> Certificaciones { get; set; } = new List<Certificacione>();

    public virtual EmpresasCuentasBancaria CuentaEmpresa { get; set; }

    public virtual ICollection<DevolucionesVentum> DevolucionesVenta { get; set; } = new List<DevolucionesVentum>();

    public virtual ICollection<FacturacionPlanificacion> FacturacionPlanificacions { get; set; } = new List<FacturacionPlanificacion>();

    public virtual ICollection<FacturasVentum> FacturasVenta { get; set; } = new List<FacturasVentum>();

    public virtual ICollection<LiquidacionesComercial> LiquidacionesComercials { get; set; } = new List<LiquidacionesComercial>();

    public virtual ICollection<Ope> Opes { get; set; } = new List<Ope>();

    public virtual ICollection<PedidosCompra> PedidosCompras { get; set; } = new List<PedidosCompra>();

    public virtual ICollection<PedidosVentum> PedidosVenta { get; set; } = new List<PedidosVentum>();

    public virtual ICollection<PresupuestosCompra> PresupuestosCompras { get; set; } = new List<PresupuestosCompra>();

    public virtual ICollection<PresupuestosVentum> PresupuestosVenta { get; set; } = new List<PresupuestosVentum>();

    public virtual ICollection<Proveedore> Proveedores { get; set; } = new List<Proveedore>();

    public virtual ICollection<SrvContrato> SrvContratos { get; set; } = new List<SrvContrato>();

    public virtual ICollection<SrvPresupuestosVentum> SrvPresupuestosVenta { get; set; } = new List<SrvPresupuestosVentum>();

    public virtual ICollection<VencimientosCompra> VencimientosCompras { get; set; } = new List<VencimientosCompra>();

    public virtual ICollection<VencimientosVentum> VencimientosVenta { get; set; } = new List<VencimientosVentum>();
}
