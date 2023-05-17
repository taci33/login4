using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class Cliente
{
    public int Idpersona { get; set; }

    public long? Idcdbo { get; set; }

    public string CodigoConta { get; set; }

    public int? DepartamentoId { get; set; }

    public int? TipoId { get; set; }

    public int? DescuentoId { get; set; }

    public int? FormaPagoId { get; set; }

    public int? MedioPagoId { get; set; }

    public int? SerieId { get; set; }

    public int? RappelId { get; set; }

    public int? TipoPorteId { get; set; }

    public string Nombre { get; set; }

    public string NombreComercial { get; set; }

    public string CifNif { get; set; }

    public string Telefono { get; set; }

    public string Fax { get; set; }

    public string Email { get; set; }

    public bool ExentoIva { get; set; }

    public bool RecargoEq { get; set; }

    public string PaginaWeb { get; set; }

    public int Estado { get; set; }

    public int? TipoFacturacionId { get; set; }

    public int? TarifaId { get; set; }

    public decimal DtoComercial { get; set; }

    public int? DireccionFraId { get; set; }

    public string Notas { get; set; }

    public string Efectos { get; set; }

    public int? ComercialId { get; set; }

    public int? ComisionId { get; set; }

    public int? AgenciaId { get; set; }

    public int? TarifaAgenciaId { get; set; }

    /// <summary>
    /// Cuenta bancaria por defecto para documentos
    /// </summary>
    public int? CuentaBancariaId { get; set; }

    public int? CuentaBancariaEmpresaId { get; set; }

    /// <summary>
    /// Indica si lleva Gesti¥n de fidelizaci¥n de puntos para el m¥dulo de CRM
    /// </summary>
    public bool CrmFidelizacion { get; set; }

    public int? IvaclaseId { get; set; }

    public int? ConceptoRetencionId { get; set; }

    public bool Bloqueado { get; set; }

    public int? DireccionEntregaId { get; set; }

    public int? CentroCosteId { get; set; }

    public int? IvagrupoId { get; set; }

    public string Nproveedor { get; set; }

    public bool Facturae { get; set; }

    public int? FeFormatoId { get; set; }

    public bool CopiaImpresa { get; set; }

    public string FeEmail { get; set; }

    public string TaiEmailAviso { get; set; }

    public int? TipoIdentificacionId { get; set; }

    public bool M347Excluir { get; set; }

    public int? AlmacenId { get; set; }

    public int? UbicacionId { get; set; }

    public string TaiTelefono1Aviso { get; set; }

    /// <summary>
    /// Este normalmente será el móvil para SMS
    /// </summary>
    public string TaiTelefono2Aviso { get; set; }

    public bool AvEnvioEmailReq { get; set; }

    public string AvEmail { get; set; }

    public string NotasInt { get; set; }

    public short? NotasIntAviso { get; set; }

    public virtual ICollection<AlbaranesVentum> AlbaranesVenta { get; set; } = new List<AlbaranesVentum>();

    public virtual ICollection<AlbaranesVentaAnticipo> AlbaranesVentaAnticipos { get; set; } = new List<AlbaranesVentaAnticipo>();

    public virtual ICollection<AlqAlquilere> AlqAlquileres { get; set; } = new List<AlqAlquilere>();

    public virtual ICollection<AlqPresupuesto> AlqPresupuestos { get; set; } = new List<AlqPresupuesto>();

    public virtual CtaCentroCoste CentroCoste { get; set; }

    public virtual ICollection<ClientesCentrosAdministrativo> ClientesCentrosAdministrativos { get; set; } = new List<ClientesCentrosAdministrativo>();

    public virtual ICollection<ClientesContacto> ClientesContactos { get; set; } = new List<ClientesContacto>();

    public virtual ICollection<ClientesCuentasBancaria> ClientesCuentasBancaria { get; set; } = new List<ClientesCuentasBancaria>();

    public virtual ICollection<ClientesDatosDinamico> ClientesDatosDinamicos { get; set; } = new List<ClientesDatosDinamico>();

    public virtual ICollection<ClientesDescuento> ClientesDescuentos { get; set; } = new List<ClientesDescuento>();

    public virtual ICollection<ClientesDescuentosRoot> ClientesDescuentosRoots { get; set; } = new List<ClientesDescuentosRoot>();

    public virtual ICollection<ClientesDiasPago> ClientesDiasPagos { get; set; } = new List<ClientesDiasPago>();

    public virtual ICollection<ClientesDireccione> ClientesDirecciones { get; set; } = new List<ClientesDireccione>();

    public virtual ICollection<ClientesMandato> ClientesMandatos { get; set; } = new List<ClientesMandato>();

    public virtual ICollection<ClientesPeriodosExentosPago> ClientesPeriodosExentosPagos { get; set; } = new List<ClientesPeriodosExentosPago>();

    public virtual ICollection<ClientesTelefono> ClientesTelefonos { get; set; } = new List<ClientesTelefono>();

    public virtual ConceptosRetencion ConceptoRetencion { get; set; }

    public virtual ICollection<CrmAccione> CrmAcciones { get; set; } = new List<CrmAccione>();

    public virtual ICollection<CrmCampanyasDestinatario> CrmCampanyasDestinatarios { get; set; } = new List<CrmCampanyasDestinatario>();

    public virtual CrmClientesPunto CrmClientesPunto { get; set; }

    public virtual ICollection<CrmClientesSegmento> CrmClientesSegmentos { get; set; } = new List<CrmClientesSegmento>();

    public virtual ICollection<CrmLiquidacione> CrmLiquidaciones { get; set; } = new List<CrmLiquidacione>();

    public virtual ICollection<CrmOportunidade> CrmOportunidades { get; set; } = new List<CrmOportunidade>();

    public virtual ICollection<CrmTarjetasFidelizacion> CrmTarjetasFidelizacions { get; set; } = new List<CrmTarjetasFidelizacion>();

    public virtual ICollection<DevolucionesVentum> DevolucionesVenta { get; set; } = new List<DevolucionesVentum>();

    public virtual ClientesDireccione DireccionEntrega { get; set; }

    public virtual ICollection<FacturasVentum> FacturasVenta { get; set; } = new List<FacturasVentum>();

    public virtual FeFormato FeFormato { get; set; }

    public virtual ICollection<IsoEncuesta> IsoEncuesta { get; set; } = new List<IsoEncuesta>();

    public virtual Ivagrupo Ivagrupo { get; set; }

    public virtual ICollection<LabOa> LabOas { get; set; } = new List<LabOa>();

    public virtual ICollection<Lote> Lotes { get; set; } = new List<Lote>();

    public virtual ICollection<OrdenesFabricacion> OrdenesFabricacions { get; set; } = new List<OrdenesFabricacion>();

    public virtual ICollection<OrdenesSeriada> OrdenesSeriada { get; set; } = new List<OrdenesSeriada>();

    public virtual ICollection<PedidosVentum> PedidosVenta { get; set; } = new List<PedidosVentum>();

    public virtual ICollection<PresupuestosVentum> PresupuestosVenta { get; set; } = new List<PresupuestosVentum>();

    public virtual ICollection<Proyecto> Proyectos { get; set; } = new List<Proyecto>();

    public virtual Series Serie { get; set; }

    public virtual ICollection<SrvContrato> SrvContratos { get; set; } = new List<SrvContrato>();

    public virtual ICollection<SrvPresupuestosVentum> SrvPresupuestosVenta { get; set; } = new List<SrvPresupuestosVentum>();

    public virtual ICollection<Tpvticket> Tpvtickets { get; set; } = new List<Tpvticket>();

    public virtual ICollection<Vale> Vales { get; set; } = new List<Vale>();

    public virtual ICollection<Comerciale> Comercials { get; set; } = new List<Comerciale>();
}
