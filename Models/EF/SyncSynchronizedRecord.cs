using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class SyncSynchronizedRecord
{
    public int IdsynchronizedRecord { get; set; }

    public int ConnectionId { get; set; }

    public int EntidadId { get; set; }

    public int EntidadKeyValue { get; set; }

    public int IdremoteKeyValue { get; set; }

    public DateTime Fsynch { get; set; }

    public virtual SyncConnection Connection { get; set; }

    public virtual GsEntidade Entidad { get; set; }
}
