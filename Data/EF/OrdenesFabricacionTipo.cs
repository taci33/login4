using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class OrdenesFabricacionTipo
{
    public int Idtipo { get; set; }

    public string Nombre { get; set; }

    public virtual ICollection<OrdenesFabricacion> OrdenesFabricacions { get; set; } = new List<OrdenesFabricacion>();

    public virtual ICollection<OrdenesSeriada> OrdenesSeriada { get; set; } = new List<OrdenesSeriada>();

    public virtual ICollection<Parte> Partes { get; set; } = new List<Parte>();

    public virtual ICollection<PartesTipo> ParteTipos { get; set; } = new List<PartesTipo>();
}
