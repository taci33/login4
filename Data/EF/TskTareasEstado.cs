using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class TskTareasEstado
{
    public int Idestado { get; set; }

    public string Nombre { get; set; }

    public string FontColor { get; set; }

    public int ImageIndex { get; set; }

    public bool? AllowModify { get; set; }

    public bool? Traspaso { get; set; }

    public virtual ICollection<Tarea> Tareas { get; set; } = new List<Tarea>();

    public virtual ICollection<TskTarea> TskTareas { get; set; } = new List<TskTarea>();
}
