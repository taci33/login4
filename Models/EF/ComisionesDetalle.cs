using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class ComisionesDetalle
{
    public int IdcomisionDetalle { get; set; }

    public int ComisionId { get; set; }

    public int ProductoId { get; set; }

    public int? OperacionId { get; set; }

    public double CantidadDesde { get; set; }

    public double Comision { get; set; }

    public int? MedidaId { get; set; }

    public int? UnidadMedidaId { get; set; }

    public virtual Comisione ComisionNavigation { get; set; }

    public virtual ComisionesOperacione Operacion { get; set; }

    public virtual Producto Producto { get; set; }

    public virtual UnidadesMedidum UnidadesMedidum { get; set; }
}
