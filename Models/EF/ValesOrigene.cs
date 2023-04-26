using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class ValesOrigene
{
    public int Idorigen { get; set; }

    public string Nombre { get; set; }

    public virtual ICollection<Vale> Vales { get; set; } = new List<Vale>();
}
