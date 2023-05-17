using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class ComercialesTipo
{
    public int IdcomercialTipo { get; set; }

    public string Nombre { get; set; }

    public virtual ICollection<Comerciale> Comerciales { get; set; } = new List<Comerciale>();
}
