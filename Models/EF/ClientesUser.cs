using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class ClientesUser
{
    public string Id { get; set; }

    public string UserName { get; set; }

    public string NormalizedUserName { get; set; }

    public string Email { get; set; }

    public string NormalizedEmail { get; set; }

    public bool EmailConfirmed { get; set; }

    public string PasswordHash { get; set; }

    public string SecurityStamp { get; set; }

    public string ConcurrencyStamp { get; set; }

    public string PhoneNumber { get; set; }

    public bool PhoneNumberConfirmed { get; set; }

    public bool TwoFactorEnabled { get; set; }

    public DateTimeOffset? LockoutEnd { get; set; }

    public bool LockoutEnabled { get; set; }

    public int AccessFailedCount { get; set; }

    public virtual ICollection<ClientesUserClaim> ClientesUserClaims { get; set; } = new List<ClientesUserClaim>();

    public virtual ICollection<ClientesUserLogin> ClientesUserLogins { get; set; } = new List<ClientesUserLogin>();

    public virtual ICollection<ClientesUsertoken> ClientesUsertokens { get; set; } = new List<ClientesUsertoken>();

    public virtual ICollection<ClientesRole> Roles { get; set; } = new List<ClientesRole>();
}
