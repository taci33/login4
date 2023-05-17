using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class ClientesDepartamento
{
    public int Id { get; set; }

    public int? DepartamentoId { get; set; }

    public string Nombre { get; set; }
}
