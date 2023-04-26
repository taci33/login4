using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class Clientesroleclaim
{
    public int Id { get; set; }

    public string RoleId { get; set; }

    public string ClaimType { get; set; }

    public string ClaimValue { get; set; }

    public virtual ClientesRole Role { get; set; }
}
