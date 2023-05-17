using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class OrdenesSeriadasDetalle
{
    public int Idlinea { get; set; }

    public int CabeceraId { get; set; }

    /// <summary>
    /// Para lineas NO Fase, informamos su Fase.
    /// </summary>
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

    public double TotalTiempoPreparacionTeorico { get; set; }

    public double TotalTiempoEjecucionTeorico { get; set; }

    public double TotalTiempoPreparacionReal { get; set; }

    public double TotalTiempoEjecucionReal { get; set; }

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

    public double CantidadPfentrada { get; set; }

    public double CantidadPfterminada { get; set; }

    public double CantidadPfrechazada { get; set; }

    public decimal FactorSolapamiento { get; set; }

    /// <summary>
    /// Para lineas Fase, informamos su Fase padre.
    /// </summary>
    public int? FaseId { get; set; }

    public int Orden { get; set; }

    public int? MedidaPfid { get; set; }

    public int? UnidadMedidaPfid { get; set; }

    public int MargenTipoIdteorico { get; set; }

    public int MargenTipoIdreal { get; set; }

    public int? IvaTipoId { get; set; }

    public virtual OrdenesSeriada Cabecera { get; set; }

    public virtual CentrosTrabajo Centro { get; set; }

    public virtual Cualificacione Cualificacion { get; set; }

    public virtual OrdenesSeriadasEstado Estado { get; set; }

    public virtual ICollection<OrdenesSeriadasDetalle> InverseLinea { get; set; } = new List<OrdenesSeriadasDetalle>();

    public virtual IvaClase IvaClase { get; set; }

    public virtual IvaTipo IvaTipo { get; set; }

    public virtual Ivagrupo Ivagrupo { get; set; }

    public virtual OrdenesSeriadasDetalle Linea { get; set; }

    public virtual Lote Lote { get; set; }

    public virtual ICollection<LotesTraza> LotesTrazaLineaOsiddestinoNavigations { get; set; } = new List<LotesTraza>();

    public virtual ICollection<LotesTraza> LotesTrazaLineaOsidorigenNavigations { get; set; } = new List<LotesTraza>();

    public virtual MargenesTipo MargenTipoIdrealNavigation { get; set; }

    public virtual MargenesTipo MargenTipoIdteoricoNavigation { get; set; }

    public virtual Medida Medida { get; set; }

    public virtual Medida MedidaPf { get; set; }

    public virtual Operacione Operacion { get; set; }

    public virtual ICollection<Parte> Partes { get; set; } = new List<Parte>();

    public virtual Producto Producto { get; set; }

    public virtual UnidadesMedidum UnidadMedida { get; set; }

    public virtual UnidadesMedidum UnidadMedidaPf { get; set; }
}
