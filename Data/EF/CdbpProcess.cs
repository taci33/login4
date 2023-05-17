using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class CdbpProcess
{
    public int Idprocess { get; set; }

    /// <summary>
    /// Formato: CDBP_DDDD, del 3000 en adelante reservados para el usuario
    /// </summary>
    public string Codigo { get; set; }

    public string Caption { get; set; }

    public string Descripcion { get; set; }

    public string Hint { get; set; }

    /// <summary>
    /// Indica si el proceso es visible para los usuarios del ERP
    /// </summary>
    public bool IsPublic { get; set; }

    /// <summary>
    /// 1 &gt; Proceso monolítico que se ejecuta en SIDBS
    /// </summary>
    public int TipoId { get; set; }

    public virtual ICollection<CdbpStep> CdbpSteps { get; set; } = new List<CdbpStep>();

    public virtual ICollection<GsEntidade> Entidads { get; set; } = new List<GsEntidade>();
}
