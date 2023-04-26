using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class CrmPuntosTablaDetalle
{
    public int IdpuntosTablaDetalle { get; set; }

    public int PuntosTablaId { get; set; }

    public int ProductoId { get; set; }

    public decimal ValorPunto { get; set; }

    public virtual ICollection<CrmClientesPuntosDetalle> CrmClientesPuntosDetalles { get; set; } = new List<CrmClientesPuntosDetalle>();

    public virtual Producto Producto { get; set; }

    public virtual CrmPuntosTabla PuntosTabla { get; set; }
}
