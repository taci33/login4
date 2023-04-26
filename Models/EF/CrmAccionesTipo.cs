using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class CrmAccionesTipo
{
    public int Idtipo { get; set; }

    public string Nombre { get; set; }

    public int TipoGenericoId { get; set; }

    public virtual ICollection<CrmAccione> CrmAcciones { get; set; } = new List<CrmAccione>();

    public virtual CrmAccionesTiposGenerico TipoGenerico { get; set; }
}
