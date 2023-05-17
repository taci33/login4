using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class DocumentosAlmacenTipo
{
    public int IddocumentoAlmacenTipo { get; set; }

    public string Nombre { get; set; }

    public bool? UpdatePrecioCompra { get; set; }

    public bool? UpdateStock { get; set; }

    public virtual ICollection<MovimientosAlmacen> MovimientosAlmacens { get; set; } = new List<MovimientosAlmacen>();
}
