using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class AtributosCatalogo
{
    public int CatalogoAtributoId { get; set; }

    public int AtributoProductoId { get; set; }

    public int IdatributoCatalogo { get; set; }

    public int? NumeroOrden { get; set; }

    public virtual AtributosProducto AtributoProducto { get; set; }

    public virtual CatalogosAtributo CatalogoAtributo { get; set; }
}
