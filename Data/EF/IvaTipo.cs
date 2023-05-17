using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class IvaTipo
{
    public int IdivaTipo { get; set; }

    public int IvaClaseId { get; set; }

    public DateTime Fecha { get; set; }

    public decimal General { get; set; }

    public decimal Recargo { get; set; }

    public string CtaIvasoportado { get; set; }

    public string CtaIvarepercutido { get; set; }

    public string CtaRecargoSoportado { get; set; }

    public string CtaRecargoRepercutido { get; set; }

    public string CtaIvaintracomunitarioSoportado { get; set; }

    public string CtaIvaintracomunitarioRepercutido { get; set; }

    public string CtaIvainversionSujetoPasivoS { get; set; }

    public string CtaIvainversionSujetoPasivoR { get; set; }

    public virtual ICollection<AlbaranesCompraDetalle> AlbaranesCompraDetalles { get; set; } = new List<AlbaranesCompraDetalle>();

    public virtual ICollection<AlbaranesVentaDetalle> AlbaranesVentaDetalles { get; set; } = new List<AlbaranesVentaDetalle>();

    public virtual ICollection<AlqAlquileresDetalle> AlqAlquileresDetalles { get; set; } = new List<AlqAlquileresDetalle>();

    public virtual ICollection<AlqPresupuestosDetalle> AlqPresupuestosDetalles { get; set; } = new List<AlqPresupuestosDetalle>();

    public virtual ICollection<DevolucionesVentaDetalle> DevolucionesVentaDetalles { get; set; } = new List<DevolucionesVentaDetalle>();

    public virtual ICollection<FacturasCompraDetalle> FacturasCompraDetalles { get; set; } = new List<FacturasCompraDetalle>();

    public virtual ICollection<FacturasCompraPie> FacturasCompraPies { get; set; } = new List<FacturasCompraPie>();

    public virtual ICollection<FacturasVentaDetalle> FacturasVentaDetalles { get; set; } = new List<FacturasVentaDetalle>();

    public virtual IvaClase IvaClase { get; set; }

    public virtual ICollection<LabBoletinesDetalle> LabBoletinesDetalles { get; set; } = new List<LabBoletinesDetalle>();

    public virtual ICollection<LabOasDetalle> LabOasDetalles { get; set; } = new List<LabOasDetalle>();

    public virtual ICollection<LiquidacionesComercialDetalle> LiquidacionesComercialDetalles { get; set; } = new List<LiquidacionesComercialDetalle>();

    public virtual ICollection<OpesDetalle> OpesDetalles { get; set; } = new List<OpesDetalle>();

    public virtual ICollection<OrdenesFabricacionDetalle> OrdenesFabricacionDetalles { get; set; } = new List<OrdenesFabricacionDetalle>();

    public virtual ICollection<OrdenesSeriadasDetalle> OrdenesSeriadasDetalles { get; set; } = new List<OrdenesSeriadasDetalle>();

    public virtual ICollection<PedidosCompraDetalle> PedidosCompraDetalles { get; set; } = new List<PedidosCompraDetalle>();

    public virtual ICollection<PedidosVentaDetalle> PedidosVentaDetalles { get; set; } = new List<PedidosVentaDetalle>();

    public virtual ICollection<PresupuestosCompraDetalle> PresupuestosCompraDetalles { get; set; } = new List<PresupuestosCompraDetalle>();

    public virtual ICollection<PresupuestosVentaDetalle> PresupuestosVentaDetalles { get; set; } = new List<PresupuestosVentaDetalle>();

    public virtual ICollection<SrvContratosDetalle> SrvContratosDetalles { get; set; } = new List<SrvContratosDetalle>();

    public virtual ICollection<SrvPresupuestosVentaDetalle> SrvPresupuestosVentaDetalles { get; set; } = new List<SrvPresupuestosVentaDetalle>();

    public virtual ICollection<TpvticketsDetalle> TpvticketsDetalles { get; set; } = new List<TpvticketsDetalle>();
}
