using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class Empleado
{
    public int Idempleado { get; set; }

    public string Nif { get; set; }

    public string Nombre { get; set; }

    public string Apellido1 { get; set; }

    public string Apellido2 { get; set; }

    public DateTime? FechaNacimiento { get; set; }

    public int? CualificacionId { get; set; }

    public int? EmpleadoPuestoId { get; set; }

    public int? EmpleadoDepartamentoId { get; set; }

    public int? EmpleadoContratoTipoId { get; set; }

    public DateTime? FinContrato { get; set; }

    public byte[] Fotografia { get; set; }

    public DateTime? FechaAlta { get; set; }

    public string NumeroSs { get; set; }

    public int? EmpleadoEstadoCivilId { get; set; }

    public int? NumeroHijos { get; set; }

    public bool? Discapacidad { get; set; }

    public int? DiscapacidadPorcentaje { get; set; }

    public string Email { get; set; }

    public string Alias { get; set; }

    public string Usr { get; set; }

    public string Pw { get; set; }

    public bool? Activo { get; set; }

    public DateTime? FechaBaja { get; set; }

    public int? DepartamentoId { get; set; }

    public int? SeccionId { get; set; }

    public bool CarneConducir { get; set; }

    public int? TipoCarneConducirId { get; set; }

    public string Empresas { get; set; }

    public string Puestos { get; set; }

    public string Observaciones { get; set; }

    public int CotizacionPerCent { get; set; }

    public decimal PcosteHora { get; set; }

    public decimal PhoraExtra { get; set; }

    public decimal PhoraExtraFestivo { get; set; }

    public decimal PrimaLaborable { get; set; }

    public decimal PrimaFestivo { get; set; }

    public decimal PrimaCompensacionFestivo { get; set; }

    public decimal PrimaMensual { get; set; }

    public decimal PhoraReten { get; set; }

    public decimal ServicioReten { get; set; }

    public int? CalendarioId { get; set; }

    public bool LiquidacionPrimas { get; set; }

    public bool AccesoPartesOtrosEmpleados { get; set; }

    public string LiquidacionPrimasObservaciones { get; set; }

    public string NumeroTarjetaId { get; set; }

    /// <summary>
    /// Determina si el Empleado realiza o no Fichajes, se tiene en cuenta en el Visor de Fichajes a la hora de mostrar los Fichajes no realizados
    /// </summary>
    public bool Fichajes { get; set; }

    public bool IsReadOnly { get; set; }

    public bool? AutoEdit { get; set; }

    public double NhorasSemanaContrato { get; set; }

    public bool? FiAllowUpdateTime { get; set; }

    public bool AllowAllComerciales { get; set; }

    public virtual ICollection<AlbaranesCompra> AlbaranesCompras { get; set; } = new List<AlbaranesCompra>();

    public virtual ICollection<AlbaranesVentum> AlbaranesVentumEmpleadoResponsables { get; set; } = new List<AlbaranesVentum>();

    public virtual ICollection<AlbaranesVentum> AlbaranesVentumEmpleados { get; set; } = new List<AlbaranesVentum>();

    public virtual ICollection<AlqAlquilere> AlqAlquileres { get; set; } = new List<AlqAlquilere>();

    public virtual ICollection<AlqAlquileresDetalle> AlqAlquileresDetalles { get; set; } = new List<AlqAlquileresDetalle>();

    public virtual ICollection<AlqPresupuesto> AlqPresupuestos { get; set; } = new List<AlqPresupuesto>();

    public virtual ICollection<AlqPresupuestosDetalle> AlqPresupuestosDetalles { get; set; } = new List<AlqPresupuestosDetalle>();

    public virtual ICollection<Autofactura> Autofacturas { get; set; } = new List<Autofactura>();

    public virtual ICollection<BienesAmortizable> BienesAmortizables { get; set; } = new List<BienesAmortizable>();

    public virtual Calendario Calendario { get; set; }

    public virtual ICollection<CalendarioDiasEmpleado> CalendarioDiasEmpleados { get; set; } = new List<CalendarioDiasEmpleado>();

    public virtual ICollection<Comerciale> Comerciales { get; set; } = new List<Comerciale>();

    public virtual ICollection<CrmAccione> CrmAccioneComercialEmpleados { get; set; } = new List<CrmAccione>();

    public virtual ICollection<CrmAccione> CrmAccioneEmpleados { get; set; } = new List<CrmAccione>();

    public virtual ICollection<CrmCampanya> CrmCampanyas { get; set; } = new List<CrmCampanya>();

    public virtual ICollection<CtaCuentasIntercambio> CtaCuentasIntercambios { get; set; } = new List<CtaCuentasIntercambio>();

    public virtual Cualificacione Cualificacion { get; set; }

    public virtual Departamento Departamento { get; set; }

    public virtual ICollection<DevolucionesVentum> DevolucionesVentumEmpleadoResponsables { get; set; } = new List<DevolucionesVentum>();

    public virtual ICollection<DevolucionesVentum> DevolucionesVentumEmpleados { get; set; } = new List<DevolucionesVentum>();

    public virtual EmpleadosContratosTipo EmpleadoContratoTipo { get; set; }

    public virtual EmpleadosDepartamento EmpleadoDepartamento { get; set; }

    public virtual EmpleadosEstadosCivile EmpleadoEstadoCivil { get; set; }

    public virtual ICollection<EmpleadosDireccione> EmpleadosDirecciones { get; set; } = new List<EmpleadosDireccione>();

    public virtual ICollection<EmpleadosTelefono> EmpleadosTelefonos { get; set; } = new List<EmpleadosTelefono>();

    public virtual ICollection<Expedicione> ExpedicioneEmpleadoResponsables { get; set; } = new List<Expedicione>();

    public virtual ICollection<Expedicione> ExpedicioneEmpleados { get; set; } = new List<Expedicione>();

    public virtual ICollection<FacturasCompra> FacturasCompras { get; set; } = new List<FacturasCompra>();

    public virtual ICollection<FacturasVentum> FacturasVenta { get; set; } = new List<FacturasVentum>();

    public virtual ICollection<Fichaje> FichajesNavigation { get; set; } = new List<Fichaje>();

    public virtual ICollection<FichajesTareasStandBy> FichajesTareasStandBies { get; set; } = new List<FichajesTareasStandBy>();

    public virtual ICollection<GsUsrGridsViewsCustomization> GsUsrGridsViewsCustomizations { get; set; } = new List<GsUsrGridsViewsCustomization>();

    public virtual ICollection<IsoActividadesPersonal> IsoActividadesPersonals { get; set; } = new List<IsoActividadesPersonal>();

    public virtual ICollection<IsoDocumento> IsoDocumentos { get; set; } = new List<IsoDocumento>();

    public virtual ICollection<IsoEncuesta> IsoEncuesta { get; set; } = new List<IsoEncuesta>();

    public virtual ICollection<IsoIncidencia> IsoIncidencia { get; set; } = new List<IsoIncidencia>();

    public virtual ICollection<IsoIncidenciasDetalle> IsoIncidenciasDetalles { get; set; } = new List<IsoIncidenciasDetalle>();

    public virtual ICollection<IsoIndicadore> IsoIndicadores { get; set; } = new List<IsoIndicadore>();

    public virtual ICollection<IsoMantenimiento> IsoMantenimientos { get; set; } = new List<IsoMantenimiento>();

    public virtual ICollection<IsoProveedore> IsoProveedores { get; set; } = new List<IsoProveedore>();

    public virtual ICollection<IsoRegistro> IsoRegistros { get; set; } = new List<IsoRegistro>();

    public virtual ICollection<LabBoletine> LabBoletineEmpleados { get; set; } = new List<LabBoletine>();

    public virtual ICollection<LabBoletine> LabBoletineResponsableRecepcions { get; set; } = new List<LabBoletine>();

    public virtual ICollection<LabBoletinesDetalle> LabBoletinesDetalles { get; set; } = new List<LabBoletinesDetalle>();

    public virtual ICollection<LabOa> LabOaEmpleados { get; set; } = new List<LabOa>();

    public virtual ICollection<LabOa> LabOaResponsables { get; set; } = new List<LabOa>();

    public virtual ICollection<LabOasLectura> LabOasLecturas { get; set; } = new List<LabOasLectura>();

    public virtual ICollection<LiquidacionesComercial> LiquidacionesComercialEmpleadoDestinatarios { get; set; } = new List<LiquidacionesComercial>();

    public virtual ICollection<LiquidacionesComercial> LiquidacionesComercialEmpleados { get; set; } = new List<LiquidacionesComercial>();

    public virtual ICollection<Ope> Opes { get; set; } = new List<Ope>();

    public virtual ICollection<OrdenesFabricacionDetalleEmpleado> OrdenesFabricacionDetalleEmpleados { get; set; } = new List<OrdenesFabricacionDetalleEmpleado>();

    public virtual ICollection<OrdenesFabricacion> OrdenesFabricacionEmpleadoResponsables { get; set; } = new List<OrdenesFabricacion>();

    public virtual ICollection<OrdenesFabricacion> OrdenesFabricacionEmpleados { get; set; } = new List<OrdenesFabricacion>();

    public virtual ICollection<OrdenesSeriada> OrdenesSeriadaEmpleadoResponsables { get; set; } = new List<OrdenesSeriada>();

    public virtual ICollection<OrdenesSeriada> OrdenesSeriadaEmpleados { get; set; } = new List<OrdenesSeriada>();

    public virtual ICollection<OrdenesSeriadasExplosione> OrdenesSeriadasExplosiones { get; set; } = new List<OrdenesSeriadasExplosione>();

    public virtual ICollection<Parte> Partes { get; set; } = new List<Parte>();

    public virtual ICollection<PedidosCompra> PedidosCompras { get; set; } = new List<PedidosCompra>();

    public virtual ICollection<PedidosVentum> PedidosVentumEmpleadoResponsables { get; set; } = new List<PedidosVentum>();

    public virtual ICollection<PedidosVentum> PedidosVentumEmpleados { get; set; } = new List<PedidosVentum>();

    public virtual ICollection<PermisosEmpleado> PermisosEmpleados { get; set; } = new List<PermisosEmpleado>();

    public virtual ICollection<PresupuestosCompra> PresupuestosCompras { get; set; } = new List<PresupuestosCompra>();

    public virtual ICollection<PresupuestosVentum> PresupuestosVentumEmpleadoResponsables { get; set; } = new List<PresupuestosVentum>();

    public virtual ICollection<PresupuestosVentum> PresupuestosVentumEmpleados { get; set; } = new List<PresupuestosVentum>();

    public virtual ICollection<Producto> Productos { get; set; } = new List<Producto>();

    public virtual ICollection<Proyecto> ProyectoEmpleadoResponsables { get; set; } = new List<Proyecto>();

    public virtual ICollection<Proyecto> ProyectoEmpleados { get; set; } = new List<Proyecto>();

    public virtual ICollection<RrhhPrimasLiquidacionDetalle> RrhhPrimasLiquidacionDetalles { get; set; } = new List<RrhhPrimasLiquidacionDetalle>();

    public virtual ICollection<RrhhPrimasLiquidacion> RrhhPrimasLiquidacionEmpleados { get; set; } = new List<RrhhPrimasLiquidacion>();

    public virtual ICollection<RrhhPrimasLiquidacion> RrhhPrimasLiquidacionPersonas { get; set; } = new List<RrhhPrimasLiquidacion>();

    public virtual Seccione Seccion { get; set; }

    public virtual ICollection<SrvContrato> SrvContratos { get; set; } = new List<SrvContrato>();

    public virtual ICollection<SrvPresupuestosVentum> SrvPresupuestosVenta { get; set; } = new List<SrvPresupuestosVentum>();

    public virtual ICollection<Tarea> TareaEmpleadoAsignados { get; set; } = new List<Tarea>();

    public virtual ICollection<Tarea> TareaEmpleados { get; set; } = new List<Tarea>();

    public virtual CarneConducirTipo TipoCarneConducir { get; set; }

    public virtual ICollection<Tpvcambio> Tpvcambios { get; set; } = new List<Tpvcambio>();

    public virtual ICollection<TpvmovimientosCaja> TpvmovimientosCajas { get; set; } = new List<TpvmovimientosCaja>();

    public virtual ICollection<TpvpagosPorCaja> TpvpagosPorCajas { get; set; } = new List<TpvpagosPorCaja>();

    public virtual ICollection<Tpvticket> Tpvtickets { get; set; } = new List<Tpvticket>();

    public virtual ICollection<TpvticketsDetalle> TpvticketsDetalles { get; set; } = new List<TpvticketsDetalle>();

    public virtual ICollection<Vale> Vales { get; set; } = new List<Vale>();

    public virtual ICollection<CentrosTrabajo> Centros { get; set; } = new List<CentrosTrabajo>();

    public virtual ICollection<IsoCurso> Cursos { get; set; } = new List<IsoCurso>();

    public virtual ICollection<Puesto> PuestosNavigation { get; set; } = new List<Puesto>();

    public virtual ICollection<IsoRevisione> Revisions { get; set; } = new List<IsoRevisione>();
}
