using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class TpvticketsEstado
{
    public int Idestado { get; set; }

    public string Nombre { get; set; }

    public string FontColor { get; set; }

    public bool Traspaso { get; set; }

    public bool CantidadPendiente { get; set; }

    public bool? AllowModify { get; set; }

    public virtual ICollection<Tpvticket> Tpvtickets { get; set; } = new List<Tpvticket>();

    public virtual ICollection<TpvticketsDetalle> TpvticketsDetalles { get; set; } = new List<TpvticketsDetalle>();
}
