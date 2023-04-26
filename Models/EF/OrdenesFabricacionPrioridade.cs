using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class OrdenesFabricacionPrioridade
{
    public int Idprioridad { get; set; }

    public string Nombre { get; set; }

    public string FontColor { get; set; }

    public int Orden { get; set; }

    public virtual ICollection<OrdenesFabricacion> OrdenesFabricacions { get; set; } = new List<OrdenesFabricacion>();

    public virtual ICollection<OrdenesSeriada> OrdenesSeriada { get; set; } = new List<OrdenesSeriada>();
}
