using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class Entidade
{
    public string Codigo { get; set; }

    public string Nombre { get; set; }

    public virtual ICollection<Agencia> Agencia { get; set; } = new List<Agencia>();
}
