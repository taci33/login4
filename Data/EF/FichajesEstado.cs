using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class FichajesEstado
{
    public int Idestado { get; set; }

    public string Nombre { get; set; }

    public string FontColor { get; set; }

    public virtual ICollection<Fichaje> Fichajes { get; set; } = new List<Fichaje>();
}
