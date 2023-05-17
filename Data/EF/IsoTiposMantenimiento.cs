using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class IsoTiposMantenimiento
{
    public int Idtipo { get; set; }

    public string Nombre { get; set; }

    public virtual ICollection<IsoMantenimiento> IsoMantenimientos { get; set; } = new List<IsoMantenimiento>();
}
