using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class ConfiguracionEmpresa
{
    public int Idempresa { get; set; }

    public string NifCif { get; set; }

    public string Nombre { get; set; }

    public string Direccion { get; set; }

    public string Telefono1 { get; set; }

    public string Telefono2 { get; set; }

    public string Fax { get; set; }

    public int LocalidadId { get; set; }

    public int ProvinciaId { get; set; }

    public int PaisId { get; set; }

    public string Cp { get; set; }

    public string Email { get; set; }

    public string PaginaWeb { get; set; }

    public string Registro { get; set; }

    public bool RegimenEspecial { get; set; }

    public string AliasReport { get; set; }

    public bool RegistroIntracomunitario { get; set; }

    public Guid? Idguid { get; set; }

    public string CodigoCuentaCotizacion { get; set; }

    public int? LaboratorioCodigo { get; set; }

    public byte NumeroEmpresa { get; set; }

    public string Rgpdtext { get; set; }

    public virtual ICollection<AlbaranesCompra> AlbaranesCompras { get; set; } = new List<AlbaranesCompra>();

    public virtual ICollection<AlbaranesVentum> AlbaranesVenta { get; set; } = new List<AlbaranesVentum>();

    public virtual ICollection<AlqAlquilere> AlqAlquileres { get; set; } = new List<AlqAlquilere>();

    public virtual ICollection<AlqPresupuesto> AlqPresupuestos { get; set; } = new List<AlqPresupuesto>();

    public virtual ICollection<Autofactura> Autofacturas { get; set; } = new List<Autofactura>();

    public virtual ICollection<ConfiguracionEmpresaCtum> ConfiguracionEmpresaCta { get; set; } = new List<ConfiguracionEmpresaCtum>();

    public virtual ICollection<CrmAccione> CrmAcciones { get; set; } = new List<CrmAccione>();

    public virtual ICollection<CrmCampanya> CrmCampanyas { get; set; } = new List<CrmCampanya>();

    public virtual ICollection<DevolucionesVentum> DevolucionesVenta { get; set; } = new List<DevolucionesVentum>();

    public virtual ICollection<EmpresasCuentasBancaria> EmpresasCuentasBancaria { get; set; } = new List<EmpresasCuentasBancaria>();

    public virtual ICollection<EmpresasDiasPago> EmpresasDiasPagos { get; set; } = new List<EmpresasDiasPago>();

    public virtual ICollection<EmpresasEmailCuenta> EmpresasEmailCuenta { get; set; } = new List<EmpresasEmailCuenta>();

    public virtual ICollection<EmpresasPeriodosExentosPago> EmpresasPeriodosExentosPagos { get; set; } = new List<EmpresasPeriodosExentosPago>();

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

    public virtual ICollection<Proyecto> Proyectos { get; set; } = new List<Proyecto>();

    public virtual ICollection<RrhhPrimasLiquidacion> RrhhPrimasLiquidacions { get; set; } = new List<RrhhPrimasLiquidacion>();

    public virtual ICollection<SrvContrato> SrvContratos { get; set; } = new List<SrvContrato>();

    public virtual ICollection<SrvPresupuestosVentum> SrvPresupuestosVenta { get; set; } = new List<SrvPresupuestosVentum>();

    public virtual ICollection<Tpvticket> Tpvtickets { get; set; } = new List<Tpvticket>();

    public virtual ICollection<Vale> Vales { get; set; } = new List<Vale>();
}
