using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class CrmAccionesMedio
{
    public int Idmedio { get; set; }

    public string Nombre { get; set; }

    public virtual ICollection<CrmAccione> CrmAcciones { get; set; } = new List<CrmAccione>();
}
