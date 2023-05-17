using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class CrmCamposCriterio
{
    /// <summary>
    /// ID 1-100 para Fijos; Segmentos a partir de 100
    /// </summary>
    public int IdcampoCriterio { get; set; }

    public string Nombre { get; set; }

    public string Funcion { get; set; }

    public string TableName { get; set; }

    public string FieldName { get; set; }

    public int? SegmentoId { get; set; }

    public virtual ICollection<CrmCampanyasCriterio> CrmCampanyasCriterios { get; set; } = new List<CrmCampanyasCriterio>();

    public virtual CrmSegmento Segmento { get; set; }
}
