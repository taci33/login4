using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class LabBoletinesDetalleDatosDinamico
{
    public int LineaId { get; set; }

    public string Valor { get; set; }

    public int IddatoDinamicoRecordEntidad { get; set; }

    public int DatoDinamicoGsEntidadDefId { get; set; }

    public virtual LabBoletinesDetalle Linea { get; set; }
}
