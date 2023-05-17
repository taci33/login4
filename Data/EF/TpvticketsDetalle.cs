using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class TpvticketsDetalle
{
    public int Idlinea { get; set; }

    public long? Idcdbo { get; set; }

    public int CabeceraId { get; set; }

    public int? LineaId { get; set; }

    public int? TipoLineaId { get; set; }

    public int? EstadoId { get; set; }

    public int ProductoId { get; set; }

    public int? MedidaId { get; set; }

    public int? UnidadMedidaId { get; set; }

    public int? IvaClaseId { get; set; }

    public decimal? Descuento { get; set; }

    public int? NumLinea { get; set; }

    public string Descripcion { get; set; }

    public double Cantidad { get; set; }

    public double? CantidadPendiente { get; set; }

    public double? CantidadServida { get; set; }

    public double Precio { get; set; }

    public double Pvp { get; set; }

    public double Coste { get; set; }

    public decimal? Margen { get; set; }

    public decimal BaseImponible { get; set; }

    public decimal Total { get; set; }

    public decimal? TotalCoste { get; set; }

    public string CtaConta { get; set; }

    public int? IvagrupoId { get; set; }

    public string RefPersona { get; set; }

    public int LoteId { get; set; }

    public decimal? Retencion { get; set; }

    public bool? RecargoEquivalencia { get; set; }

    public DateTime? Fentrega { get; set; }

    public string CodigoPropioProducto { get; set; }

    public string NumeroLote { get; set; }

    public Guid? UidId { get; set; }

    public int? EmpleadoId { get; set; }

    public int? PromocionId { get; set; }

    public int? Puntos { get; set; }

    public int? IvatipoId { get; set; }

    public virtual Tpvticket Cabecera { get; set; }

    public virtual Empleado Empleado { get; set; }

    public virtual TpvticketsEstado Estado { get; set; }

    public virtual TpvticketsDetalleCdbo IdcdboNavigation { get; set; }

    public virtual IvaTipo Ivatipo { get; set; }

    public virtual Lote Lote { get; set; }

    public virtual Producto Producto { get; set; }

    public virtual UnidadesMedidum UnidadesMedidum { get; set; }
}
