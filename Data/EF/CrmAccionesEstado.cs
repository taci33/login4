using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class CrmAccionesEstado
{
    public int Idestado { get; set; }

    public string Nombre { get; set; }

    public string FontColor { get; set; }

    public bool? AllowModify { get; set; }

    public bool? Traspaso { get; set; }

    public virtual ICollection<CrmAccione> CrmAcciones { get; set; } = new List<CrmAccione>();
}
