using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class CrmAccionesTiposGenerico
{
    public int IdtipoGenerico { get; set; }

    public string Tipo { get; set; }

    public int? LabelColor { get; set; }

    public virtual ICollection<CrmAccionesTipo> CrmAccionesTipos { get; set; } = new List<CrmAccionesTipo>();
}
