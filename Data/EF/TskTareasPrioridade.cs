using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class TskTareasPrioridade
{
    public int Idprioridad { get; set; }

    public string Nombre { get; set; }

    public string FontColor { get; set; }

    public int ImageIndex { get; set; }

    public int Orden { get; set; }

    public virtual ICollection<Tarea> Tareas { get; set; } = new List<Tarea>();
}
