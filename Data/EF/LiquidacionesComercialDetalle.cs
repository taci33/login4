using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class LiquidacionesComercialDetalle
{
    public int Idlinea { get; set; }

    public long? Idcdbo { get; set; }

    public int CabeceraId { get; set; }

    public int? LineaId { get; set; }

    public int EstadoId { get; set; }

    public int TipoLineaId { get; set; }

    /// <summary>
    /// Lo Informaremos en los Apartados, para coger informaci¾n de la Factura sin usar DGT
    /// </summary>
    public int? CabeceraOrigenId { get; set; }

    public int ProductoId { get; set; }

    public int? MedidaId { get; set; }

    public int? UnidadMedidaId { get; set; }

    public string Descripcion { get; set; }

    public double PrecioVenta { get; set; }

    public double Cantidad { get; set; }

    public decimal Biventa { get; set; }

    public int? ComisionId { get; set; }

    public int? OperacionId { get; set; }

    public double ImporteComision { get; set; }

    public int? IvaclaseId { get; set; }

    public decimal BaseImponible { get; set; }

    public decimal Total { get; set; }

    public int? IvaTipoId { get; set; }

    public virtual LiquidacionesComercial Cabecera { get; set; }

    public virtual Comisione Comision { get; set; }

    public virtual LiquidacionesComercialEstado Estado { get; set; }

    public virtual LiquidacionesComercialDetalleCdbo IdcdboNavigation { get; set; }

    public virtual ICollection<LiquidacionesComercialDetalle> InverseLinea { get; set; } = new List<LiquidacionesComercialDetalle>();

    public virtual IvaTipo IvaTipo { get; set; }

    public virtual IvaClase Ivaclase { get; set; }

    public virtual LiquidacionesComercialDetalle Linea { get; set; }

    public virtual ComisionesOperacione Operacion { get; set; }

    public virtual Producto Producto { get; set; }

    public virtual TiposLinea TipoLinea { get; set; }

    public virtual UnidadesMedidum UnidadesMedidum { get; set; }
}
