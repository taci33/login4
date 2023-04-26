using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class Modelo
{
    public int Idmodelo { get; set; }

    public string Nombre { get; set; }

    public virtual ICollection<ConfiguracionBloque> ConfiguracionBloques { get; set; } = new List<ConfiguracionBloque>();
}
