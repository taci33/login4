using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class GdFormatosArchivo
{
    public int Idformato { get; set; }

    public string Nombre { get; set; }

    public int? AplicacionId { get; set; }

    public string Extension { get; set; }

    public byte[] Icon { get; set; }

    public virtual GdAplicacione Aplicacion { get; set; }

    public virtual ICollection<CrmCampanyasDocumento> CrmCampanyasDocumentos { get; set; } = new List<CrmCampanyasDocumento>();

    public virtual ICollection<GdDocumento> GdDocumentos { get; set; } = new List<GdDocumento>();
}
