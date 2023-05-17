using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class BienesAmortizablesEstado
{
    public int Idestado { get; set; }

    public string Nombre { get; set; }

    public string FontColor { get; set; }

    public bool AllowModify { get; set; }

    public virtual ICollection<BienesAmortizable> BienesAmortizables { get; set; } = new List<BienesAmortizable>();
}
