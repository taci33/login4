using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class ProductosSugerido
{
    public int ProductoId { get; set; }

    public int? ProductoCompuestoId { get; set; }

    public int ProductoSugeridoId { get; set; }

    public string Descripcion { get; set; }

    public double CantidadDesde { get; set; }

    public double Cantidad { get; set; }

    public bool Requerido { get; set; }

    public virtual Producto Producto { get; set; }

    public virtual Producto ProductoSugerido { get; set; }
}
