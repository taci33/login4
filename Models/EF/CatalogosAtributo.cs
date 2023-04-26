using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class CatalogosAtributo
{
    public int IdcatalogoAtributo { get; set; }

    public string Nombre { get; set; }

    public virtual ICollection<AtributosCatalogo> AtributosCatalogos { get; set; } = new List<AtributosCatalogo>();

    public virtual ICollection<Familia> Familia { get; set; } = new List<Familia>();
}
