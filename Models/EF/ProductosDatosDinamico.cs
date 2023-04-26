using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class ProductosDatosDinamico
{
    public int IddatoDinamicoRecordEntidad { get; set; }

    public int ProductoId { get; set; }

    public int DatoDinamicoGsEntidadDefId { get; set; }

    public string Valor { get; set; }

    public virtual DatosDinamicosGsEntidadesDef DatoDinamicoGsEntidadDef { get; set; }

    public virtual Producto Producto { get; set; }
}
