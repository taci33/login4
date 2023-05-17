using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class CrmOportunidadesPrioridade
{
    public int Idprioridad { get; set; }

    public string Nombre { get; set; }

    public string FontColor { get; set; }

    public int ImageIndex { get; set; }

    public int Orden { get; set; }

    public virtual ICollection<CrmOportunidade> CrmOportunidades { get; set; } = new List<CrmOportunidade>();
}
