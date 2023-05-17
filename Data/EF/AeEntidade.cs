using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class AeEntidade
{
    public int EntidadId { get; set; }

    public virtual GsEntidade Entidad { get; set; }
}
