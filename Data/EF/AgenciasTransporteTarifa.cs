using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class AgenciasTransporteTarifa
{
    public int IdtarifaAgencia { get; set; }

    public string Nombre { get; set; }

    public int? AgenciaId { get; set; }

    public string TaiCodeServicio { get; set; }

    public string TaiCodeProducto { get; set; }

    public virtual Proveedore Agencia { get; set; }

    public virtual ICollection<AgenciasTransporteTarifasDetalle> AgenciasTransporteTarifasDetalles { get; set; } = new List<AgenciasTransporteTarifasDetalle>();

    public virtual ICollection<AlbaranesVentum> AlbaranesVenta { get; set; } = new List<AlbaranesVentum>();

    public virtual ICollection<AlqAlquilere> AlqAlquileres { get; set; } = new List<AlqAlquilere>();

    public virtual ICollection<AlqPresupuesto> AlqPresupuestos { get; set; } = new List<AlqPresupuesto>();

    public virtual ICollection<DevolucionesVentum> DevolucionesVenta { get; set; } = new List<DevolucionesVentum>();

    public virtual ICollection<Expedicione> Expediciones { get; set; } = new List<Expedicione>();

    public virtual ICollection<FacturasVentum> FacturasVenta { get; set; } = new List<FacturasVentum>();

    public virtual ICollection<PedidosCompra> PedidosCompras { get; set; } = new List<PedidosCompra>();

    public virtual ICollection<PedidosVentum> PedidosVenta { get; set; } = new List<PedidosVentum>();

    public virtual ICollection<PresupuestosVentum> PresupuestosVenta { get; set; } = new List<PresupuestosVentum>();

    public virtual ICollection<SrvContrato> SrvContratos { get; set; } = new List<SrvContrato>();

    public virtual ICollection<SrvPresupuestosVentum> SrvPresupuestosVenta { get; set; } = new List<SrvPresupuestosVentum>();
}
