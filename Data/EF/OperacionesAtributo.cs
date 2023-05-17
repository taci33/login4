using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class OperacionesAtributo
{
    public int AtributoId { get; set; }

    public virtual AtributosProducto Atributo { get; set; }

    public virtual ICollection<Operacione> Operaciones { get; set; } = new List<Operacione>();
}
