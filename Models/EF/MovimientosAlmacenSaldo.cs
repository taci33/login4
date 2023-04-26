using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class MovimientosAlmacenSaldo
{
    public DateTime Fecha { get; set; }

    public int ProductoId { get; set; }

    public int LoteId { get; set; }

    public int AlmacenId { get; set; }

    public int UbicacionId { get; set; }

    public double Saldo { get; set; }

    public virtual Almacene Almacen { get; set; }

    public virtual Lote Lote { get; set; }

    public virtual Producto Producto { get; set; }

    public virtual AlmacenesUbicacione Ubicacion { get; set; }
}
