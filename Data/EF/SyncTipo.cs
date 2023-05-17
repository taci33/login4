using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class SyncTipo
{
    public int Idtipo { get; set; }

    public string Nombre { get; set; }

    public string Descripcion { get; set; }

    public bool Enabled { get; set; }

    public string SyncCode { get; set; }

    public virtual ICollection<SyncConnection> SyncConnections { get; set; } = new List<SyncConnection>();

    public virtual ICollection<GsEntidade> Entidads { get; set; } = new List<GsEntidade>();
}
