using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class PresupuestosVentaProductosActualizable
{
    public int IdproductoActualizable { get; set; }

    public int CabeceraId { get; set; }

    public int ProductoId { get; set; }

    public double Coste { get; set; }

    public double Precio { get; set; }

    public virtual PresupuestosVentum Cabecera { get; set; }

    public virtual Producto Producto { get; set; }
}
