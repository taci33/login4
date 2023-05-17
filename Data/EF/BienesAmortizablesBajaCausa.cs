using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class BienesAmortizablesBajaCausa
{
    public int IdcausaBaja { get; set; }

    public string Codigo { get; set; }

    public string Nombre { get; set; }

    public virtual ICollection<BienesAmortizable> BienesAmortizables { get; set; } = new List<BienesAmortizable>();
}
