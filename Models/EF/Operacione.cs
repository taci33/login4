using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class Operacione
{
    public int Idoperacion { get; set; }

    /// <summary>
    /// Referencia a la tabla AtributosProducto
    /// </summary>
    public int AtributoId { get; set; }

    /// <summary>
    /// Referencia a la tabla ValoresProductos
    /// </summary>
    public int ValorId { get; set; }

    public string Nombre { get; set; }

    public string Notas { get; set; }

    public virtual OperacionesAtributo Atributo { get; set; }

    public virtual ICollection<Fase> Fases { get; set; } = new List<Fase>();

    public virtual ICollection<FichajesOrdenesOperacionesListum> FichajesOrdenesOperacionesLista { get; set; } = new List<FichajesOrdenesOperacionesListum>();

    public virtual ICollection<FichajesParte> FichajesPartes { get; set; } = new List<FichajesParte>();

    public virtual ICollection<OrdenesSeriadasDetalle> OrdenesSeriadasDetalles { get; set; } = new List<OrdenesSeriadasDetalle>();

    public virtual ICollection<Parte> Partes { get; set; } = new List<Parte>();

    public virtual ValoresProducto Valor { get; set; }
}
