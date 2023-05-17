using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class ValesEstado
{
    public int Idestado { get; set; }

    public string Nombre { get; set; }

    public string FontColor { get; set; }

    public bool Traspaso { get; set; }

    public bool CantidadPendiente { get; set; }

    public bool? AllowModify { get; set; }

    public virtual ICollection<Vale> Vales { get; set; } = new List<Vale>();
}
