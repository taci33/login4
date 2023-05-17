using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class Ejercicio
{
    public int IdEjercicio { get; set; }

    public string Nombre { get; set; }

    public int Anno { get; set; }

    public bool Cerrado { get; set; }

    public DateTime FechaInicio { get; set; }

    public DateTime FechaFin { get; set; }

    public virtual ICollection<AeatM303> AeatM303s { get; set; } = new List<AeatM303>();

    public virtual ICollection<AlbaranesCompra> AlbaranesCompras { get; set; } = new List<AlbaranesCompra>();

    public virtual ICollection<AlbaranesVentum> AlbaranesVenta { get; set; } = new List<AlbaranesVentum>();

    public virtual ICollection<AlqAlquilere> AlqAlquileres { get; set; } = new List<AlqAlquilere>();

    public virtual ICollection<AlqPresupuesto> AlqPresupuestos { get; set; } = new List<AlqPresupuesto>();

    public virtual ICollection<Autofactura> Autofacturas { get; set; } = new List<Autofactura>();

    public virtual ICollection<BienesAmortizablesDetalle> BienesAmortizablesDetalles { get; set; } = new List<BienesAmortizablesDetalle>();

    public virtual ICollection<CalendariosEjercicio> CalendariosEjercicios { get; set; } = new List<CalendariosEjercicio>();

    public virtual ICollection<CrmAccione> CrmAcciones { get; set; } = new List<CrmAccione>();

    public virtual ICollection<CrmCampanya> CrmCampanyas { get; set; } = new List<CrmCampanya>();

    public virtual ICollection<DevolucionesVentum> DevolucionesVenta { get; set; } = new List<DevolucionesVentum>();

    public virtual ICollection<Diario> Diarios { get; set; } = new List<Diario>();

    public virtual ICollection<Expedicione> Expediciones { get; set; } = new List<Expedicione>();

    public virtual ICollection<FacturasCompra> FacturasCompras { get; set; } = new List<FacturasCompra>();

    public virtual ICollection<FacturasVentum> FacturasVenta { get; set; } = new List<FacturasVentum>();

    public virtual ICollection<IvaLibroRepercutido> IvaLibroRepercutidos { get; set; } = new List<IvaLibroRepercutido>();

    public virtual ICollection<IvaLibroSoportado> IvaLibroSoportados { get; set; } = new List<IvaLibroSoportado>();

    public virtual ICollection<LabBoletine> LabBoletines { get; set; } = new List<LabBoletine>();

    public virtual ICollection<LabOa> LabOas { get; set; } = new List<LabOa>();

    public virtual ICollection<LiquidacionesComercial> LiquidacionesComercials { get; set; } = new List<LiquidacionesComercial>();

    public virtual ICollection<Ope> Opes { get; set; } = new List<Ope>();

    public virtual ICollection<OrdenesFabricacion> OrdenesFabricacions { get; set; } = new List<OrdenesFabricacion>();

    public virtual ICollection<OrdenesSeriada> OrdenesSeriada { get; set; } = new List<OrdenesSeriada>();

    public virtual ICollection<OrdenesSeriadasExplosione> OrdenesSeriadasExplosiones { get; set; } = new List<OrdenesSeriadasExplosione>();

    public virtual ICollection<PedidosCompra> PedidosCompras { get; set; } = new List<PedidosCompra>();

    public virtual ICollection<PedidosVentum> PedidosVenta { get; set; } = new List<PedidosVentum>();

    public virtual ICollection<Periodo> Periodos { get; set; } = new List<Periodo>();

    public virtual ICollection<PresupuestosCompra> PresupuestosCompras { get; set; } = new List<PresupuestosCompra>();

    public virtual ICollection<PresupuestosVentum> PresupuestosVenta { get; set; } = new List<PresupuestosVentum>();

    public virtual ICollection<Proyecto> Proyectos { get; set; } = new List<Proyecto>();

    public virtual ICollection<RemesasCompra> RemesasCompras { get; set; } = new List<RemesasCompra>();

    public virtual ICollection<RemesasVentum> RemesasVenta { get; set; } = new List<RemesasVentum>();

    public virtual ICollection<RrhhPrimasLiquidacion> RrhhPrimasLiquidacions { get; set; } = new List<RrhhPrimasLiquidacion>();

    public virtual ICollection<SrvContrato> SrvContratos { get; set; } = new List<SrvContrato>();

    public virtual ICollection<SrvPresupuestosVentum> SrvPresupuestosVenta { get; set; } = new List<SrvPresupuestosVentum>();

    public virtual ICollection<Tpvticket> Tpvtickets { get; set; } = new List<Tpvticket>();

    public virtual ICollection<Vale> Vales { get; set; } = new List<Vale>();
}
