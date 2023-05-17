using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class ClientesContactosTipo
{
    public int IdcontactoTipo { get; set; }

    public string Tipo { get; set; }

    public virtual ICollection<ClientesContacto> ClientesContactos { get; set; } = new List<ClientesContacto>();
}
