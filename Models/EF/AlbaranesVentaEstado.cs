using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class AlbaranesVentaEstado
{
    public int Idestado { get; set; }

    public string Nombre { get; set; }

    public string FontColor { get; set; }

    public bool Traspaso { get; set; }

    public bool CantidadPendiente { get; set; }

    public bool? AllowModify { get; set; }

    public virtual ICollection<AlbaranesVentum> AlbaranesVenta { get; set; } = new List<AlbaranesVentum>();

    public virtual ICollection<AlbaranesVentaDetalle> AlbaranesVentaDetalles { get; set; } = new List<AlbaranesVentaDetalle>();
}
