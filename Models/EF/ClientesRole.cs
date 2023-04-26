using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class ClientesRole
{
    public string Id { get; set; }

    public string Name { get; set; }

    public string NormalizedName { get; set; }

    public string ConcurrencyStamp { get; set; }

    public virtual ICollection<Clientesroleclaim> Clientesroleclaims { get; set; } = new List<Clientesroleclaim>();

    public virtual ICollection<ClientesUser> Users { get; set; } = new List<ClientesUser>();
}
