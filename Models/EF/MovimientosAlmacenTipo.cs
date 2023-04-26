using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class MovimientosAlmacenTipo
{
    public int Idtipo { get; set; }

    public string Nombre { get; set; }

    public string FontColor { get; set; }

    public virtual ICollection<MovimientosAlmacenDetalle> MovimientosAlmacenDetalles { get; set; } = new List<MovimientosAlmacenDetalle>();
}
