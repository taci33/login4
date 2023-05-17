using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class FichajesOrdenesOperacionesListum
{
    public int IdordenOperacion { get; set; }

    /// <summary>
    /// Tipo de la Orden (Indirecta, Fabricación, Seriada)
    /// </summary>
    public int TipoId { get; set; }

    /// <summary>
    /// ID de la Orden indirecta
    /// </summary>
    public int OfId { get; set; }

    /// <summary>
    /// ID de la Operación
    /// </summary>
    public int OperacionId { get; set; }

    public string TextoObservaciones { get; set; }

    /// <summary>
    /// Determina si al insertar una tarea de este tipo NO permitimos la inserción de otra tarea
    /// </summary>
    public bool? Excluyente { get; set; }

    /// <summary>
    /// Determina como se comporta el sistema a la hora de realizar una Salida o Fin de Turno y tener la tarea de este tipo abierta
    /// </summary>
    public bool CierreAutomatico { get; set; }

    public virtual Operacione Operacion { get; set; }
}
