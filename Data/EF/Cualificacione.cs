using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class Cualificacione
{
    public int Idcualificacion { get; set; }

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

    public virtual CualificacionesAtributo Atributo { get; set; }

    public virtual ICollection<CentrosTrabajo> CentrosTrabajos { get; set; } = new List<CentrosTrabajo>();

    public virtual ICollection<Empleado> Empleados { get; set; } = new List<Empleado>();

    public virtual ICollection<OrdenesSeriadasDetalle> OrdenesSeriadasDetalles { get; set; } = new List<OrdenesSeriadasDetalle>();

    public virtual ICollection<Parte> Partes { get; set; } = new List<Parte>();

    public virtual ValoresProducto Valor { get; set; }
}
