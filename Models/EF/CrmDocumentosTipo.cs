using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class CrmDocumentosTipo
{
    public int Idtipo { get; set; }

    public string Nombre { get; set; }

    public virtual ICollection<CrmCampanyasDocumento> CrmCampanyasDocumentos { get; set; } = new List<CrmCampanyasDocumento>();
}
