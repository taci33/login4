using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class TskTareasOrigene
{
    public int IdtareaOrigen { get; set; }

    public string Nombre { get; set; }

    public virtual ICollection<Tarea> Tareas { get; set; } = new List<Tarea>();
}
