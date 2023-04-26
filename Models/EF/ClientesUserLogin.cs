using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class ClientesUserLogin
{
    public string LoginProvider { get; set; }

    public string ProviderKey { get; set; }

    public string ProviderDisplayName { get; set; }

    public string UserId { get; set; }

    public virtual ClientesUser User { get; set; }
}
