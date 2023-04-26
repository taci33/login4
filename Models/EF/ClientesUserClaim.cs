using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class ClientesUserClaim
{
    public int Id { get; set; }

    public string UserId { get; set; }

    public string ClaimType { get; set; }

    public string ClaimValue { get; set; }

    public virtual ClientesUser User { get; set; }
}
