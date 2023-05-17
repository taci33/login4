using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class AlbaranesCompraEstado
{
    public int Idestado { get; set; }

    public string Nombre { get; set; }

    public string FontColor { get; set; }

    public bool Traspaso { get; set; }

    public bool CantidadPendiente { get; set; }

    public bool? AllowModify { get; set; }

    public virtual ICollection<AlbaranesCompraDetalle> AlbaranesCompraDetalles { get; set; } = new List<AlbaranesCompraDetalle>();

    public virtual ICollection<AlbaranesCompra> AlbaranesCompras { get; set; } = new List<AlbaranesCompra>();
}
