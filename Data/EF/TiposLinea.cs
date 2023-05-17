using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class TiposLinea
{
    public int IdtipoLinea { get; set; }

    public int TipoEdicion { get; set; }

    public string Nombre { get; set; }

    public bool IsGroupHeader { get; set; }

    public bool CreateNewTranslateDocument { get; set; }

    public bool? AplicateDtoCabecera { get; set; }

    public bool LineaCabecera { get; set; }

    public bool? SetEstadoCabecera { get; set; }

    public double CantidadDef { get; set; }

    /// <summary>
    /// GroupHeader+GestionProdYPrec
    /// </summary>
    public bool? LineaCompuesto { get; set; }

    public bool AllowInLineEdit { get; set; }

    public bool LineaCompuestoCoste { get; set; }

    public bool IsGroupHeaderYdetalle { get; set; }

    public virtual ICollection<AlbaranesCompraDetalle> AlbaranesCompraDetalles { get; set; } = new List<AlbaranesCompraDetalle>();

    public virtual ICollection<AlbaranesVentaDetalle> AlbaranesVentaDetalles { get; set; } = new List<AlbaranesVentaDetalle>();

    public virtual ICollection<AlqAlquileresDescuentosGenerale> AlqAlquileresDescuentosGenerales { get; set; } = new List<AlqAlquileresDescuentosGenerale>();

    public virtual ICollection<AlqAlquileresDetalle> AlqAlquileresDetalles { get; set; } = new List<AlqAlquileresDetalle>();

    public virtual ICollection<AlqPresupuestosDescuentosGenerale> AlqPresupuestosDescuentosGenerales { get; set; } = new List<AlqPresupuestosDescuentosGenerale>();

    public virtual ICollection<AlqPresupuestosDetalle> AlqPresupuestosDetalles { get; set; } = new List<AlqPresupuestosDetalle>();

    public virtual ICollection<DevolucionesVentaDetalle> DevolucionesVentaDetalles { get; set; } = new List<DevolucionesVentaDetalle>();

    public virtual ICollection<DocumentosGestionTiposLineaTiposLinea> DocumentosGestionTiposLineaTiposLineaParentTipoLineas { get; set; } = new List<DocumentosGestionTiposLineaTiposLinea>();

    public virtual ICollection<DocumentosGestionTiposLineaTiposLinea> DocumentosGestionTiposLineaTiposLineaTipoLineas { get; set; } = new List<DocumentosGestionTiposLineaTiposLinea>();

    public virtual ICollection<DocumentosGestionTiposLinea> DocumentosGestionTiposLineas { get; set; } = new List<DocumentosGestionTiposLinea>();

    public virtual ICollection<ExpedicionesDetalle> ExpedicionesDetalles { get; set; } = new List<ExpedicionesDetalle>();

    public virtual ICollection<FacturasCompraDetalle> FacturasCompraDetalles { get; set; } = new List<FacturasCompraDetalle>();

    public virtual ICollection<FacturasVentaDetalle> FacturasVentaDetalles { get; set; } = new List<FacturasVentaDetalle>();

    public virtual ICollection<LabBoletinesDetalle> LabBoletinesDetalles { get; set; } = new List<LabBoletinesDetalle>();

    public virtual ICollection<LabDatosDinamicosLineasDef> LabDatosDinamicosLineasDefs { get; set; } = new List<LabDatosDinamicosLineasDef>();

    public virtual ICollection<LiquidacionesComercialDetalle> LiquidacionesComercialDetalles { get; set; } = new List<LiquidacionesComercialDetalle>();

    public virtual ICollection<OpesDetalle> OpesDetalles { get; set; } = new List<OpesDetalle>();

    public virtual ICollection<PartesTipo> PartesTipos { get; set; } = new List<PartesTipo>();

    public virtual ICollection<PedidosCompraDetalle> PedidosCompraDetalles { get; set; } = new List<PedidosCompraDetalle>();

    public virtual ICollection<PedidosVentaDescuentosGenerale> PedidosVentaDescuentosGenerales { get; set; } = new List<PedidosVentaDescuentosGenerale>();

    public virtual ICollection<PedidosVentaDetalle> PedidosVentaDetalles { get; set; } = new List<PedidosVentaDetalle>();

    public virtual ICollection<PresupuestosCompraDetalle> PresupuestosCompraDetalles { get; set; } = new List<PresupuestosCompraDetalle>();

    public virtual ICollection<PresupuestosVentaDescuentosGenerale> PresupuestosVentaDescuentosGenerales { get; set; } = new List<PresupuestosVentaDescuentosGenerale>();

    public virtual ICollection<PresupuestosVentaDetalle> PresupuestosVentaDetalles { get; set; } = new List<PresupuestosVentaDetalle>();

    public virtual ICollection<RrhhPrimasLiquidacionDetalle> RrhhPrimasLiquidacionDetalles { get; set; } = new List<RrhhPrimasLiquidacionDetalle>();

    public virtual ICollection<SrvContratosDetalle> SrvContratosDetalles { get; set; } = new List<SrvContratosDetalle>();

    public virtual ICollection<SrvPresupuestosVentaDetalle> SrvPresupuestosVentaDetalles { get; set; } = new List<SrvPresupuestosVentaDetalle>();
}
