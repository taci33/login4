using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class OrdenesFabricacionOrigene
{
    public int Idorigen { get; set; }

    public string Nombre { get; set; }

    public virtual ICollection<OrdenesFabricacion> OrdenesFabricacions { get; set; } = new List<OrdenesFabricacion>();

    public virtual ICollection<OrdenesSeriada> OrdenesSeriada { get; set; } = new List<OrdenesSeriada>();
}
