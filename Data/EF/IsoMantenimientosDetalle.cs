using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class IsoMantenimientosDetalle
{
    public int Idlinea { get; set; }

    public int CabeceraId { get; set; }

    public int ProductoId { get; set; }

    public string Cantidad { get; set; }

    public virtual IsoMantenimiento Cabecera { get; set; }

    public virtual Producto Producto { get; set; }
}
