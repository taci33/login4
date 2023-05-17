using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class OpesEstado
{
    public int Idestado { get; set; }

    public string Nombre { get; set; }

    public string FontColor { get; set; }

    public bool Traspaso { get; set; }

    public bool CantidadPendiente { get; set; }

    public bool? AllowModify { get; set; }

    public virtual ICollection<Ope> Opes { get; set; } = new List<Ope>();

    public virtual ICollection<OpesDetalle> OpesDetalles { get; set; } = new List<OpesDetalle>();
}
