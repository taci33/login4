using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class AlqAlquileresDetalle
{
    public int Idlinea { get; set; }

    public long? Idcdbo { get; set; }

    public int CabeceraId { get; set; }

    public int? LineaId { get; set; }

    public int TipoLineaId { get; set; }

    public int EstadoId { get; set; }

    public int ProductoId { get; set; }

    public int? MedidaId { get; set; }

    public int? UnidadMedidaId { get; set; }

    public int? IvaClaseId { get; set; }

    public decimal Descuento { get; set; }

    public int? NumLinea { get; set; }

    public string Descripcion { get; set; }

    public double Cantidad { get; set; }

    public double CantidadServida { get; set; }

    public double CantidadPendiente { get; set; }

    public double Precio { get; set; }

    public double Coste { get; set; }

    public decimal Margen { get; set; }

    public decimal BaseImponible { get; set; }

    public decimal Total { get; set; }

    public decimal TotalCoste { get; set; }

    public string CtaConta { get; set; }

    public int? IvagrupoId { get; set; }

    public string RefPersona { get; set; }

    public int LoteId { get; set; }

    public decimal Retencion { get; set; }

    public bool RecargoEquivalencia { get; set; }

    public DateTime? Fentrega { get; set; }

    public string CodigoPropioProducto { get; set; }

    public string NumeroLote { get; set; }

    public Guid? UidId { get; set; }

    public int? ConceptoRetencionId { get; set; }

    public DateTime? Frecepcion { get; set; }

    public int? CentroCosteId { get; set; }

    public DateTime? Finicio { get; set; }

    public DateTime? Ffin { get; set; }

    public int? EmpleadoId { get; set; }

    public decimal NumeroDiasTotal { get; set; }

    public decimal NumeroDiasFacturar { get; set; }

    public double CantidadAlquiler { get; set; }

    public int MargenTipoId { get; set; }

    public decimal MargenBeneficio { get; set; }

    public decimal TotalBeneficio { get; set; }

    public int? IvaTipoId { get; set; }

    public double CosteSinDto { get; set; }

    public decimal DtoCoste { get; set; }

    public bool? IncluirMo { get; set; }

    public bool? IncluirMaterial { get; set; }

    public decimal DescuentoGeneral { get; set; }

    public virtual AlqAlquilere Cabecera { get; set; }

    public virtual CtaCentroCoste CentroCoste { get; set; }

    public virtual ConceptosRetencion ConceptoRetencion { get; set; }

    public virtual Empleado Empleado { get; set; }

    public virtual AlqAlquileresEstado Estado { get; set; }

    public virtual AlqAlquileresDetalleCdbo IdcdboNavigation { get; set; }

    public virtual ICollection<AlqAlquileresDetalle> InverseLinea { get; set; } = new List<AlqAlquileresDetalle>();

    public virtual IvaClase IvaClase { get; set; }

    public virtual IvaTipo IvaTipo { get; set; }

    public virtual Ivagrupo Ivagrupo { get; set; }

    public virtual AlqAlquileresDetalle Linea { get; set; }

    public virtual MargenesTipo MargenTipo { get; set; }

    public virtual Medida Medida { get; set; }

    public virtual Producto Producto { get; set; }

    public virtual TiposLinea TipoLinea { get; set; }

    public virtual UnidadesMedidum UnidadMedida { get; set; }
}
