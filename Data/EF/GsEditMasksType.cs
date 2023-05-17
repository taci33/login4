using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class GsEditMasksType
{
    public int IdeditMaskType { get; set; }

    public string Name { get; set; }

    public virtual ICollection<GsUsrType> GsUsrTypes { get; set; } = new List<GsUsrType>();
}
