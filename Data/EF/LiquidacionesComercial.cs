using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class LiquidacionesComercial
{
    public int Idcabecera { get; set; }

    public long? Idcdbo { get; set; }

    public int EstadoId { get; set; }

    public string Titulo { get; set; }

    public int ComercialId { get; set; }

    public int? EmpleadoDestinatarioId { get; set; }

    public int? ProveedorDestinatarioId { get; set; }

    public int SerieId { get; set; }

    public int EjercicioId { get; set; }

    public string Anno { get; set; }

    public int? Numero { get; set; }

    public DateTime Falta { get; set; }

    public string Observaciones { get; set; }

    public int? PersonaDireccionFacturaId { get; set; }

    public int? FormaPagoId { get; set; }

    public int? MedioId { get; set; }

    public string Cccadeudo { get; set; }

    public int? IvagrupoId { get; set; }

    public decimal BaseImponible { get; set; }

    public decimal TotalFinanciacion { get; set; }

    public decimal TotalRetencion { get; set; }

    public decimal Total { get; set; }

    public int? EmpleadoId { get; set; }

    public int? EmpresaId { get; set; }

    public virtual Comerciale Comercial { get; set; }

    public virtual Ejercicio Ejercicio { get; set; }

    public virtual Empleado Empleado { get; set; }

    public virtual Empleado EmpleadoDestinatario { get; set; }

    public virtual ConfiguracionEmpresa Empresa { get; set; }

    public virtual LiquidacionesComercialEstado Estado { get; set; }

    public virtual FormasPago FormaPago { get; set; }

    public virtual LiquidacionesComercialCdbo IdcdboNavigation { get; set; }

    public virtual Ivagrupo Ivagrupo { get; set; }

    public virtual ICollection<LiquidacionesComercialDetalle> LiquidacionesComercialDetalles { get; set; } = new List<LiquidacionesComercialDetalle>();

    public virtual MediosPago Medio { get; set; }

    public virtual Proveedore ProveedorDestinatario { get; set; }

    public virtual Series Serie { get; set; }
}
