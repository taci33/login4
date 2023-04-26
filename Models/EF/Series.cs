using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class Series
{
    public int Idserie { get; set; }

    public string Nombre { get; set; }

    /// <summary>
    /// vale 1 si la serie es de abono
    /// </summary>
    public bool Abono { get; set; }

    public bool Autofactura { get; set; }

    public bool Isp { get; set; }

    public string SiiFeOperacionDescripcion { get; set; }

    public string SiiFrOperacionDescripcion { get; set; }

    public virtual ICollection<AlbaranesCompra> AlbaranesCompras { get; set; } = new List<AlbaranesCompra>();

    public virtual ICollection<AlbaranesVentum> AlbaranesVenta { get; set; } = new List<AlbaranesVentum>();

    public virtual ICollection<AlqAlquilere> AlqAlquileres { get; set; } = new List<AlqAlquilere>();

    public virtual ICollection<AlqPresupuesto> AlqPresupuestos { get; set; } = new List<AlqPresupuesto>();

    public virtual ICollection<Autofactura> Autofacturas { get; set; } = new List<Autofactura>();

    public virtual ICollection<Cliente> Clientes { get; set; } = new List<Cliente>();

    public virtual ICollection<DevolucionesVentum> DevolucionesVenta { get; set; } = new List<DevolucionesVentum>();

    public virtual ICollection<Expedicione> Expediciones { get; set; } = new List<Expedicione>();

    public virtual ICollection<FacturasCompra> FacturasCompras { get; set; } = new List<FacturasCompra>();

    public virtual ICollection<FacturasVentum> FacturasVenta { get; set; } = new List<FacturasVentum>();

    public virtual ICollection<LabBoletine> LabBoletines { get; set; } = new List<LabBoletine>();

    public virtual ICollection<LabOa> LabOas { get; set; } = new List<LabOa>();

    public virtual ICollection<LiquidacionesComercial> LiquidacionesComercials { get; set; } = new List<LiquidacionesComercial>();

    public virtual ICollection<Ope> Opes { get; set; } = new List<Ope>();

    public virtual ICollection<OrdenesFabricacion> OrdenesFabricacions { get; set; } = new List<OrdenesFabricacion>();

    public virtual ICollection<OrdenesSeriada> OrdenesSeriada { get; set; } = new List<OrdenesSeriada>();

    public virtual ICollection<OrdenesSeriadasExplosione> OrdenesSeriadasExplosiones { get; set; } = new List<OrdenesSeriadasExplosione>();

    public virtual ICollection<PedidosCompra> PedidosCompras { get; set; } = new List<PedidosCompra>();

    public virtual ICollection<PedidosVentum> PedidosVenta { get; set; } = new List<PedidosVentum>();

    public virtual ICollection<PresupuestosCompra> PresupuestosCompras { get; set; } = new List<PresupuestosCompra>();

    public virtual ICollection<PresupuestosVentum> PresupuestosVenta { get; set; } = new List<PresupuestosVentum>();

    public virtual ICollection<Proveedore> Proveedores { get; set; } = new List<Proveedore>();

    public virtual ICollection<SrvContrato> SrvContratos { get; set; } = new List<SrvContrato>();

    public virtual ICollection<SrvPresupuestosVentum> SrvPresupuestosVenta { get; set; } = new List<SrvPresupuestosVentum>();

    public virtual ICollection<Tpvticket> Tpvtickets { get; set; } = new List<Tpvticket>();
}
