using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class TskTareasTipoMantenimiento
{
    /// <summary>
    /// FK a la PK de TSK_Tareas
    /// </summary>
    public int TareaId { get; set; }

    /// <summary>
    /// Llamada, email, reuni¾n cliente, interno
    /// </summary>
    public int? OrigenId { get; set; }

    /// <summary>
    /// Error, Mejora, Mejora interna, etc.
    /// </summary>
    public int? TipoId { get; set; }

    public int? OftipoId { get; set; }

    public int? Ofid { get; set; }

    public int? PersonaId { get; set; }

    public virtual TskTarea Tarea { get; set; }
}
