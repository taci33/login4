using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class GsEntidade
{
    public int Identidad { get; set; }

    public string Nombre { get; set; }

    public string TableName { get; set; }

    public string KeyField { get; set; }

    public int FormularioId { get; set; }

    public bool GestionCdbo { get; set; }

    public virtual AeEntidade AeEntidade { get; set; }

    public virtual DatosDinamicosGsEntidade DatosDinamicosGsEntidade { get; set; }

    public virtual ICollection<DireccionesEntidadesOrigen> DireccionesEntidadesOrigens { get; set; } = new List<DireccionesEntidadesOrigen>();

    public virtual ICollection<DocumentosGestion> DocumentosGestions { get; set; } = new List<DocumentosGestion>();

    public virtual Formulario Formulario { get; set; }

    public virtual GdEntidade GdEntidade { get; set; }

    public virtual ICollection<GsGridDefinition> GsGridDefinitions { get; set; } = new List<GsGridDefinition>();

    public virtual ICollection<GsGridsView> GsGridsViews { get; set; } = new List<GsGridsView>();

    public virtual ICollection<GsRecordsKey> GsRecordsKeys { get; set; } = new List<GsRecordsKey>();

    public virtual ICollection<SyncSynchronizedRecord> SyncSynchronizedRecords { get; set; } = new List<SyncSynchronizedRecord>();

    public virtual ICollection<CdbpProcess> Processes { get; set; } = new List<CdbpProcess>();

    public virtual ICollection<Report> Reports { get; set; } = new List<Report>();

    public virtual ICollection<SyncTipo> Tipos { get; set; } = new List<SyncTipo>();
}
