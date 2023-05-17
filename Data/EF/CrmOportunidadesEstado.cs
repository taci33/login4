using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class CrmOportunidadesEstado
{
    public int Idestado { get; set; }

    public string Nombre { get; set; }

    public string FontColor { get; set; }

    public virtual ICollection<CrmOportunidade> CrmOportunidades { get; set; } = new List<CrmOportunidade>();
}
