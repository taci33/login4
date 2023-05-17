using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class MaquinasEstado
{
    public int Idestado { get; set; }

    public string Nombre { get; set; }

    public virtual ICollection<Maquina> Maquinas { get; set; } = new List<Maquina>();
}
