using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class AlqAlquileresCdbo
{
    public long Idcdbo { get; set; }

    public virtual AlqAlquilere AlqAlquilere { get; set; }
}
