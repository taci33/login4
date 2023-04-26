using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class Proveedore
{
    /// <summary>
    /// 1: Proveedores; 0: Agencias de Transporte
    /// </summary>
    public int Idpersona { get; set; }

    public long? Idcdbo { get; set; }

    public int? TipoId { get; set; }

    public int? DescuentoId { get; set; }

    public int? FormaPagoId { get; set; }

    public int? MedioPagoId { get; set; }

    public int? SerieId { get; set; }

    public int? RappelId { get; set; }

    public int? TipoTransporteId { get; set; }

    public string CifNif { get; set; }

    public string Nombre { get; set; }

    public string Telefono { get; set; }

    public string Fax { get; set; }

    public string Email { get; set; }

    public string PaginaWeb { get; set; }

    public string Notas { get; set; }

    public int Estado { get; set; }

    public string CodigoConta { get; set; }

    public string Efectos { get; set; }

    public int? DireccionFraId { get; set; }

    public bool ExentoIva { get; set; }

    /// <summary>
    /// Cuenta bancaria por defecto para documentos
    /// </summary>
    public int? CuentaBancariaId { get; set; }

    public int? CuentaBancariaEmpresaId { get; set; }

    public decimal DtoComercial { get; set; }

    public string NombreComercial { get; set; }

    /// <summary>
    /// No deja introducir un Update en Cascada
    /// </summary>
    public int? IvaclaseId { get; set; }

    public int? ConceptoRetencionId { get; set; }

    public int? CentroCosteId { get; set; }

    public bool Facturae { get; set; }

    public int? IvagrupoId { get; set; }

    public bool TaiServices { get; set; }

    public string TaiCode { get; set; }

    public string TaiEmailAviso { get; set; }

    public bool M347Excluir { get; set; }

    public string TaiTelefono1Aviso { get; set; }

    /// <summary>
    /// Este normalmente será el móvil para SMS
    /// </summary>
    public string TaiTelefono2Aviso { get; set; }

    public string NotasInt { get; set; }

    public short? NotasIntAviso { get; set; }

    public virtual ICollection<AgenciasTransporteTarifa> AgenciasTransporteTarifas { get; set; } = new List<AgenciasTransporteTarifa>();

    public virtual ICollection<AlbaranesCompra> AlbaranesCompras { get; set; } = new List<AlbaranesCompra>();

    public virtual ICollection<AlbaranesVentaDetalle> AlbaranesVentaDetalles { get; set; } = new List<AlbaranesVentaDetalle>();

    public virtual CtaCentroCoste CentroCoste { get; set; }

    public virtual ICollection<CentrosTrabajo> CentrosTrabajos { get; set; } = new List<CentrosTrabajo>();

    public virtual ICollection<Comerciale> Comerciales { get; set; } = new List<Comerciale>();

    public virtual ConceptosRetencion ConceptoRetencion { get; set; }

    public virtual ICollection<Expedicione> Expediciones { get; set; } = new List<Expedicione>();

    public virtual ICollection<FacturasCompra> FacturasCompras { get; set; } = new List<FacturasCompra>();

    public virtual ICollection<FacturasVentaDetalle> FacturasVentaDetalles { get; set; } = new List<FacturasVentaDetalle>();

    public virtual FormasPago FormaPago { get; set; }

    public virtual ProveedoresCdbo IdcdboNavigation { get; set; }

    public virtual ICollection<IsoMantenimiento> IsoMantenimientos { get; set; } = new List<IsoMantenimiento>();

    public virtual IsoProveedore IsoProveedore { get; set; }

    public virtual IvaClase Ivaclase { get; set; }

    public virtual Ivagrupo Ivagrupo { get; set; }

    public virtual ICollection<LiquidacionesComercial> LiquidacionesComercials { get; set; } = new List<LiquidacionesComercial>();

    public virtual ICollection<Lote> Lotes { get; set; } = new List<Lote>();

    public virtual MediosPago MedioPago { get; set; }

    public virtual ICollection<Ope> Opes { get; set; } = new List<Ope>();

    public virtual ICollection<PedidosCompra> PedidosCompras { get; set; } = new List<PedidosCompra>();

    public virtual ICollection<PedidosVentaDetalle> PedidosVentaDetalles { get; set; } = new List<PedidosVentaDetalle>();

    public virtual ICollection<PresupuestosCompra> PresupuestosCompras { get; set; } = new List<PresupuestosCompra>();

    public virtual ICollection<PresupuestosVentaDetalle> PresupuestosVentaDetalles { get; set; } = new List<PresupuestosVentaDetalle>();

    public virtual ICollection<PropuestasCompraDetalle> PropuestasCompraDetalles { get; set; } = new List<PropuestasCompraDetalle>();

    public virtual ICollection<ProveedoresContacto> ProveedoresContactos { get; set; } = new List<ProveedoresContacto>();

    public virtual ICollection<ProveedoresCuentasBancaria> ProveedoresCuentasBancaria { get; set; } = new List<ProveedoresCuentasBancaria>();

    public virtual ICollection<ProveedoresDescuento> ProveedoresDescuentos { get; set; } = new List<ProveedoresDescuento>();

    public virtual ICollection<ProveedoresDescuentosRoot> ProveedoresDescuentosRoots { get; set; } = new List<ProveedoresDescuentosRoot>();

    public virtual ICollection<ProveedoresDiasPago> ProveedoresDiasPagos { get; set; } = new List<ProveedoresDiasPago>();

    public virtual ICollection<ProveedoresDireccione> ProveedoresDirecciones { get; set; } = new List<ProveedoresDireccione>();

    public virtual ICollection<ProveedoresPeriodosExentosPago> ProveedoresPeriodosExentosPagos { get; set; } = new List<ProveedoresPeriodosExentosPago>();

    public virtual ICollection<ProveedoresTelefono> ProveedoresTelefonos { get; set; } = new List<ProveedoresTelefono>();

    public virtual Series Serie { get; set; }

    public virtual ProveedoresTipo Tipo { get; set; }

    public virtual ICollection<IsoCriteriosSeleccion> Criterios { get; set; } = new List<IsoCriteriosSeleccion>();
}
