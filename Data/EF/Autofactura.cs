using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class Autofactura
{
    public int Idcabecera { get; set; }

    public int EjercicioId { get; set; }

    public int SerieId { get; set; }

    public DateTime Falta { get; set; }

    public string Anno { get; set; }

    public int? Numero { get; set; }

    public string Codigo { get; set; }

    public string Titulo { get; set; }

    public int EstadoId { get; set; }

    public int? EmpresaId { get; set; }

    public int? EmpleadoId { get; set; }

    public bool Contabilizada { get; set; }

    public int FacturaCompraId { get; set; }

    public decimal BaseImponible { get; set; }

    public decimal Total { get; set; }

    public virtual Ejercicio Ejercicio { get; set; }

    public virtual Empleado Empleado { get; set; }

    public virtual ConfiguracionEmpresa Empresa { get; set; }

    public virtual AutofacturasEstado Estado { get; set; }

    public virtual FacturasCompra FacturaCompra { get; set; }

    public virtual Series Serie { get; set; }
}
