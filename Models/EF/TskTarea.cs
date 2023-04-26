using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class TskTarea
{
    public int Idtarea { get; set; }

    public int? TareaId { get; set; }

    public Guid Idguid { get; set; }

    /// <summary>
    /// Empleado que da de alta la tarea
    /// </summary>
    public int EmpleadoId { get; set; }

    /// <summary>
    /// Empresa a la que pertenece el EmpleadoID
    /// </summary>
    public int EmpresaId { get; set; }

    /// <summary>
    /// FK contra la tabla TareasTipos, define las clases para cada tipo de Tarea (Mant. Soft., Bßsica, Personal, etc.)
    /// </summary>
    public int TipoId { get; set; }

    public int EstadoId { get; set; }

    public DateTime? FechaInicioTeorica { get; set; }

    public DateTime? FechaFinTeorica { get; set; }

    public DateTime? FechaInicioReal { get; set; }

    public DateTime? FechaFinReal { get; set; }

    public string Asunto { get; set; }

    public string Notas { get; set; }

    /// <summary>
    /// cxScheduler
    /// </summary>
    public int EventType { get; set; }

    /// <summary>
    /// cxScheduler
    /// </summary>
    public int? LabelColor { get; set; }

    /// <summary>
    /// cxScheduler
    /// </summary>
    public string Location { get; set; }

    /// <summary>
    /// cxScheduler
    /// </summary>
    public int? Options { get; set; }

    public DateTime? ReminderDate { get; set; }

    public int? ReminderMinutesBeforeStart { get; set; }

    public string ReminderResourcesData { get; set; }

    public int? TaskComplete { get; set; }

    public int? TaskIndex { get; set; }

    public string TaskLinks { get; set; }

    public int? TaskStatus { get; set; }

    public string AppointmentItemEntryId { get; set; }

    public virtual TskTareasEstado Estado { get; set; }

    public virtual TskTareasTipoMantenimiento TskTareasTipoMantenimiento { get; set; }
}
