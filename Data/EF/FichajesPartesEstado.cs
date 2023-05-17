using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class FichajesPartesEstado
{
    public int Idestado { get; set; }

    public string Nombre { get; set; }

    public virtual ICollection<FichajesParte> FichajesPartes { get; set; } = new List<FichajesParte>();
}
