using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class Tpvticket
{
    public int Idcabecera { get; set; }

    public int Tpvid { get; set; }

    public long? Idcdbo { get; set; }

    public string Titulo { get; set; }

    public int? Tipo { get; set; }

    public int? PersonaId { get; set; }

    public int? SerieId { get; set; }

    public int? PersonaDireccionFacturaId { get; set; }

    public bool? Entrega { get; set; }

    public int? PersonaDireccionEntregaId { get; set; }

    public int? FormaPagoId { get; set; }

    public int? EstadoId { get; set; }

    public string Anno { get; set; }

    public int? Numero { get; set; }

    public DateTime? Falta { get; set; }

    public DateTime? Fentrega { get; set; }

    public decimal? BaseImponible { get; set; }

    public decimal? Total { get; set; }

    public decimal? TotalCoste { get; set; }

    public string Observaciones { get; set; }

    public decimal? Descuento { get; set; }

    public int? IvagrupoId { get; set; }

    public int? PortesTipoId { get; set; }

    public decimal? TotalPortes { get; set; }

    public decimal? TotalFinanciacion { get; set; }

    public decimal? TotalRetencion { get; set; }

    public int? EjercicioId { get; set; }

    public bool? Entregado { get; set; }

    public bool? Arreglo { get; set; }

    public bool? Contabilizado { get; set; }

    public bool? Abierto { get; set; }

    public DateTime? Hora { get; set; }

    public int? TarifaId { get; set; }

    public int? EmpleadoId { get; set; }

    public int? EmpresaId { get; set; }

    public decimal MargenBeneficio { get; set; }

    public DateTime? Foperacion { get; set; }

    public bool SiiExportado { get; set; }

    public string DescripcionOperacion { get; set; }

    public virtual Ejercicio Ejercicio { get; set; }

    public virtual Empleado Empleado { get; set; }

    public virtual ConfiguracionEmpresa Empresa { get; set; }

    public virtual TpvticketsEstado Estado { get; set; }

    public virtual TpvticketsCdbo IdcdboNavigation { get; set; }

    public virtual Ivagrupo Ivagrupo { get; set; }

    public virtual Cliente Persona { get; set; }

    public virtual ClientesDireccione PersonaDireccionEntrega { get; set; }

    public virtual ClientesDireccione PersonaDireccionFactura { get; set; }

    public virtual Series Serie { get; set; }

    public virtual Tarifa Tarifa { get; set; }

    public virtual Tpv Tpv { get; set; }

    public virtual ICollection<TpvmovimientosCaja> TpvmovimientosCajas { get; set; } = new List<TpvmovimientosCaja>();

    public virtual ICollection<TpvticketsDetalle> TpvticketsDetalles { get; set; } = new List<TpvticketsDetalle>();

    public virtual ICollection<Vale> Vales { get; set; } = new List<Vale>();

    public virtual ICollection<ValesDetalle> ValesDetalles { get; set; } = new List<ValesDetalle>();
}
