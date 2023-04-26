using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class OrdenesFabricacionDetalle
{
    public int Idlinea { get; set; }

    public int CabeceraId { get; set; }

    public int? LineaId { get; set; }

    public int? NumLinea { get; set; }

    public int EstadoId { get; set; }

    public int TipoLineaId { get; set; }

    public int ProductoId { get; set; }

    public int? LoteId { get; set; }

    public int? OperacionId { get; set; }

    public int? CentroId { get; set; }

    public int? CualificacionId { get; set; }

    public int? IvaClaseId { get; set; }

    public int? IvagrupoId { get; set; }

    public decimal Descuento { get; set; }

    public string Descripcion { get; set; }

    public DateTime? FechaInicioTeorica { get; set; }

    public DateTime? FechaFinTeorica { get; set; }

    public DateTime? FechaInicioReal { get; set; }

    public DateTime? FechaFinReal { get; set; }

    public double CantidadTeorica { get; set; }

    public int? MedidaId { get; set; }

    public int? UnidadMedidaId { get; set; }

    public double CosteTeorico { get; set; }

    public decimal TotalCosteTeorico { get; set; }

    public decimal MargenTeorico { get; set; }

    public double PrecioTeorico { get; set; }

    public decimal TotalVentaTeorico { get; set; }

    public double CantidadServida { get; set; }

    public double CantidadReal { get; set; }

    public double CosteReal { get; set; }

    public decimal TotalCosteReal { get; set; }

    public decimal MargenReal { get; set; }

    public double PrecioReal { get; set; }

    public decimal TotalVentaReal { get; set; }

    public int MargenTipoIdteorico { get; set; }

    public int MargenTipoIdreal { get; set; }

    public bool Entregado { get; set; }

    public DateTime? FechaInicio { get; set; }

    public DateTime? FechaFin { get; set; }

    public int? IvaTipoId { get; set; }

    public bool GestCorte { get; set; }

    public double UnidadesCorte { get; set; }

    public double CantidadX { get; set; }

    public double CantidadY { get; set; }

    public double CantidadZ { get; set; }

    public int? UnidadMedidaIdCorteX { get; set; }

    public int? UnidadMedidaIdCorteY { get; set; }

    public int? UnidadMedidaIdCorteZ { get; set; }

    public double? CantidadXInicial { get; set; }

    public double? CantidadYInicial { get; set; }

    public double? CantidadZInicial { get; set; }

    public double? NumeroCX { get; set; }

    public double? NumeroCY { get; set; }

    public double? NumeroCZ { get; set; }

    public virtual OrdenesFabricacion Cabecera { get; set; }

    public virtual OrdenesFabricacionEstado Estado { get; set; }

    public virtual IvaClase IvaClase { get; set; }

    public virtual IvaTipo IvaTipo { get; set; }

    public virtual Ivagrupo Ivagrupo { get; set; }

    public virtual MargenesTipo MargenTipoIdrealNavigation { get; set; }

    public virtual MargenesTipo MargenTipoIdteoricoNavigation { get; set; }

    public virtual Medida Medida { get; set; }

    public virtual ICollection<OrdenesFabricacionDetalleEmpleado> OrdenesFabricacionDetalleEmpleados { get; set; } = new List<OrdenesFabricacionDetalleEmpleado>();

    public virtual ICollection<Parte> Partes { get; set; } = new List<Parte>();

    public virtual Producto Producto { get; set; }

    public virtual UnidadesMedidum UnidadMedida { get; set; }

    public virtual UnidadesMedidum UnidadMedidaIdCorteXNavigation { get; set; }

    public virtual UnidadesMedidum UnidadMedidaIdCorteYNavigation { get; set; }

    public virtual UnidadesMedidum UnidadMedidaIdCorteZNavigation { get; set; }
}
