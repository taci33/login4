using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class ClientesUsertoken
{
    public string UserId { get; set; }

    public string LoginProvider { get; set; }

    public string Name { get; set; }

    public string Value { get; set; }

    public virtual ClientesUser User { get; set; }
}
