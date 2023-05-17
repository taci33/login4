using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class GsRecordsKey
{
    public long Idrecord { get; set; }

    public int EntidadId { get; set; }

    public int UserId { get; set; }

    public DateTime FechaHora { get; set; }

    public virtual GsEntidade Entidad { get; set; }
}
