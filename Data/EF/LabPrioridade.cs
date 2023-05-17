using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class LabPrioridade
{
    public int Idprioridad { get; set; }

    public string Nombre { get; set; }

    public string FontColor { get; set; }

    public int Orden { get; set; }

    public virtual ICollection<LabBoletine> LabBoletines { get; set; } = new List<LabBoletine>();

    public virtual ICollection<LabOa> LabOas { get; set; } = new List<LabOa>();
}
