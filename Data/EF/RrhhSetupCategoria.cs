using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class RrhhSetupCategoria
{
    public int Idcategoria { get; set; }

    public string Nombre { get; set; }

    public string Caption { get; set; }

    public string Descripcion { get; set; }

    public virtual ICollection<RrhhSetup> RrhhSetups { get; set; } = new List<RrhhSetup>();
}
