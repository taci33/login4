using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class ProductosConjuntosDatosDinamico
{
    public int IddatoDinamicoRecordEntidad { get; set; }

    public int ConjuntoId { get; set; }

    public int DatoDinamicoGsEntidadDefId { get; set; }

    public string Valor { get; set; }

    public virtual ProductosConjunto Conjunto { get; set; }

    public virtual DatosDinamicosGsEntidadesDef DatoDinamicoGsEntidadDef { get; set; }
}
