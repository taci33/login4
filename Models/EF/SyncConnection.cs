using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class SyncConnection
{
    public int Idconnection { get; set; }

    public Guid Idguid { get; set; }

    public int TipoId { get; set; }

    public string Nombre { get; set; }

    public string Descripcion { get; set; }

    public string Server { get; set; }

    public string Provider { get; set; }

    public string Datasource { get; set; }

    public string Username { get; set; }

    public string Password { get; set; }

    public virtual ICollection<SyncSynchronization> SyncSynchronizations { get; set; } = new List<SyncSynchronization>();

    public virtual ICollection<SyncSynchronizedRecord> SyncSynchronizedRecords { get; set; } = new List<SyncSynchronizedRecord>();

    public virtual SyncTipo Tipo { get; set; }

    public virtual ICollection<Familia> Familia { get; set; } = new List<Familia>();
}
