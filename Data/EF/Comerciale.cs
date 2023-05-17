using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class Comerciale
{
    public int Idcomercial { get; set; }

    public string Nombre { get; set; }

    public int? ComercialId { get; set; }

    public int? ComercialTipoId { get; set; }

    public bool Externo { get; set; }

    public int? ProveedorId { get; set; }

    public int? EmpleadoId { get; set; }

    public string Observaciones { get; set; }

    public int? ComisionId { get; set; }

    public int? ComisionResponsableId { get; set; }

    public bool? Activo { get; set; }

    public virtual ICollection<AlbaranesVentum> AlbaranesVenta { get; set; } = new List<AlbaranesVentum>();

    public virtual ICollection<AlqAlquilere> AlqAlquileres { get; set; } = new List<AlqAlquilere>();

    public virtual ICollection<AlqPresupuesto> AlqPresupuestos { get; set; } = new List<AlqPresupuesto>();

    public virtual Comerciale Comercial { get; set; }

    public virtual ComercialesTipo ComercialTipo { get; set; }

    public virtual Comisione Comision { get; set; }

    public virtual Comisione ComisionResponsable { get; set; }

    public virtual ICollection<CrmAccione> CrmAcciones { get; set; } = new List<CrmAccione>();

    public virtual ICollection<DevolucionesVentum> DevolucionesVenta { get; set; } = new List<DevolucionesVentum>();

    public virtual Empleado Empleado { get; set; }

    public virtual ICollection<FacturasVentum> FacturasVenta { get; set; } = new List<FacturasVentum>();

    public virtual ICollection<Comerciale> InverseComercial { get; set; } = new List<Comerciale>();

    public virtual ICollection<LiquidacionesComercial> LiquidacionesComercials { get; set; } = new List<LiquidacionesComercial>();

    public virtual ICollection<PedidosVentum> PedidosVenta { get; set; } = new List<PedidosVentum>();

    public virtual ICollection<PresupuestosVentum> PresupuestosVenta { get; set; } = new List<PresupuestosVentum>();

    public virtual Proveedore Proveedor { get; set; }

    public virtual ICollection<SrvContrato> SrvContratos { get; set; } = new List<SrvContrato>();

    public virtual ICollection<SrvPresupuestosVentum> SrvPresupuestosVenta { get; set; } = new List<SrvPresupuestosVentum>();

    public virtual ICollection<Cliente> Personas { get; set; } = new List<Cliente>();
}
