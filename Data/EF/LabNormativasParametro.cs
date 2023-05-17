using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class LabNormativasParametro
{
    public int Idnormativa { get; set; }

    public string Nombre { get; set; }

    public string Documento { get; set; }

    public long Idcdbo { get; set; }

    public virtual ProductosCompuestosCdbo IdcdboNavigation { get; set; }
}
