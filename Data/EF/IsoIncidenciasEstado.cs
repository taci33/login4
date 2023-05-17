using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class IsoIncidenciasEstado
{
    public int Idestado { get; set; }

    public string Nombre { get; set; }

    public virtual ICollection<IsoIncidencia> IsoIncidencia { get; set; } = new List<IsoIncidencia>();
}
