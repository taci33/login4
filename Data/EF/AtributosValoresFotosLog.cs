using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class AtributosValoresFotosLog
{
    public int Idlog { get; set; }

    public int ValorAtributoId { get; set; }

    public int Operacion { get; set; }

    public bool Procesado { get; set; }

    public DateTime? Fecha { get; set; }

    public virtual ValoresProducto ValorAtributo { get; set; }
}
