using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class ValoresProducto
{
    public int IdvalorProducto { get; set; }

    public int? ValorProductoId { get; set; }

    public int AtributoProductoId { get; set; }

    public string Nombre { get; set; }

    public int Indice { get; set; }

    public virtual AtributosProducto AtributoProducto { get; set; }

    public virtual ICollection<AtributosValoresFotosLog> AtributosValoresFotosLogs { get; set; } = new List<AtributosValoresFotosLog>();

    public virtual ICollection<Cualificacione> Cualificaciones { get; set; } = new List<Cualificacione>();

    public virtual ICollection<ValoresProducto> InverseValorProducto { get; set; } = new List<ValoresProducto>();

    public virtual ICollection<Operacione> Operaciones { get; set; } = new List<Operacione>();

    public virtual ICollection<ProductosAtribsValore> ProductosAtribsValores { get; set; } = new List<ProductosAtribsValore>();

    public virtual ValoresProducto ValorProducto { get; set; }
}
