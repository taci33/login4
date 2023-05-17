using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class Tarea
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
    /// FK contra la tabla TSK_TareasClases, define las clases para cada tipo de Tarea (Mant. Soft., Básica, Personal, etc.)
    /// </summary>
    public int TipoClaseId { get; set; }

    public int EstadoId { get; set; }

    public DateTime FechaAlta { get; set; }

    public DateTime FechaAviso { get; set; }

    public DateTime? FechaInicioTeorica { get; set; }

    public DateTime? FechaFinTeorica { get; set; }

    public DateTime? FechaInicioReal { get; set; }

    public DateTime? FechaFinReal { get; set; }

    public string Asunto { get; set; }

    public string Notas { get; set; }

    public int PrioridadId { get; set; }

    /// <summary>
    /// Llamada, email, reunión cliente, interno
    /// </summary>
    public int OrigenId { get; set; }

    public int? EmpleadoAsignadoId { get; set; }

    /// <summary>
    /// Error, Mejora, Mejora interna, etc.
    /// </summary>
    public int TipoId { get; set; }

    public int? ProyectoId { get; set; }

    public int? OftipoId { get; set; }

    public int? Ofid { get; set; }

    public int? OfdetalleId { get; set; }

    public int? PersonaId { get; set; }

    public virtual Empleado Empleado { get; set; }

    public virtual Empleado EmpleadoAsignado { get; set; }

    public virtual TskTareasEstado Estado { get; set; }

    public virtual TskTareasOrigene Origen { get; set; }

    public virtual TskTareasPrioridade Prioridad { get; set; }

    public virtual TskTareasMantenimientoTipo Tipo { get; set; }

    public virtual TskTareasClase TipoClase { get; set; }
}
