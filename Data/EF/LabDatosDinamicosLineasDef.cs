using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class LabDatosDinamicosLineasDef
{
    public int IddatoDinamicoLineaDef { get; set; }

    public int DatoDinamicoId { get; set; }

    public int LabTipoLineaId { get; set; }

    public int LabTipoLineaCategoryId { get; set; }

    public string DefaultValue { get; set; }

    public virtual LabDatosDinamico DatoDinamico { get; set; }

    public virtual TiposLinea LabTipoLinea { get; set; }
}
