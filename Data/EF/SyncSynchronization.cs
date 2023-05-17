using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class SyncSynchronization
{
    public int Idsynchronization { get; set; }

    public int? EmpleadoId { get; set; }

    public DateTime Finicio { get; set; }

    public DateTime? Ffin { get; set; }

    public int ConnectionId { get; set; }

    public string Notas { get; set; }

    public virtual SyncConnection Connection { get; set; }
}
