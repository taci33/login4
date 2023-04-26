using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class CualificacionesAtributo
{
    public int AtributoId { get; set; }

    public virtual AtributosProducto Atributo { get; set; }

    public virtual ICollection<Cualificacione> Cualificaciones { get; set; } = new List<Cualificacione>();
}
