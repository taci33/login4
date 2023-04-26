using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class CrmAccione
{
    public int Idcabecera { get; set; }

    public long? Idcdbo { get; set; }

    public int EjercicioId { get; set; }

    public string Anno { get; set; }

    public int? Numero { get; set; }

    public string Codigo { get; set; }

    public DateTime Falta { get; set; }

    public int EstadoAccionId { get; set; }

    public int? TipoAccionId { get; set; }

    public int? CabeceraOrigenId { get; set; }

    public int PersonaId { get; set; }

    public int? PersonaDireccionId { get; set; }

    public int? PersonaContactoId { get; set; }

    public string Telefono { get; set; }

    public int ComercialId { get; set; }

    public int? ComercialEmpleadoId { get; set; }

    public int EstadoComercialEmpleadoId { get; set; }

    public int IniciativaId { get; set; }

    public int MedioId { get; set; }

    public string Asunto { get; set; }

    public string Motivo { get; set; }

    public string Origen { get; set; }

    public DateTime FechaInicio { get; set; }

    public DateTime FechaFin { get; set; }

    public string Lugar { get; set; }

    public string Notas { get; set; }

    public int? ResultadoId { get; set; }

    public string Observaciones { get; set; }

    public decimal Coste { get; set; }

    public int? OportunidadId { get; set; }

    public int EmpleadoId { get; set; }

    public int EmpresaId { get; set; }

    public int RecurrenceType { get; set; }

    public int LabelColor { get; set; }

    public int RecurrenceIndex { get; set; }

    public string RecurrenceInfo { get; set; }

    public int? CabeceraRecurrenceId { get; set; }

    public int? Options { get; set; }

    public int? ActualFinish { get; set; }

    public int? ActualStart { get; set; }

    public DateTime? ReminderDate { get; set; }

    public int? ReminderMinutesBeforeStart { get; set; }

    public string ReminderResourcesData { get; set; }

    public int? TaskComplete { get; set; }

    public int? TaskIndex { get; set; }

    public string TaskLinks { get; set; }

    public int? TaskStatus { get; set; }

    public string AppointmentItemEntryId { get; set; }

    public string Email { get; set; }

    public virtual CrmAccione CabeceraOrigen { get; set; }

    public virtual CrmAccione CabeceraRecurrence { get; set; }

    public virtual ClientesContacto ClientesContacto { get; set; }

    public virtual ClientesDireccione ClientesDireccione { get; set; }

    public virtual Comerciale Comercial { get; set; }

    public virtual Empleado ComercialEmpleado { get; set; }

    public virtual Ejercicio Ejercicio { get; set; }

    public virtual Empleado Empleado { get; set; }

    public virtual ConfiguracionEmpresa Empresa { get; set; }

    public virtual CrmAccionesEstado EstadoAccion { get; set; }

    public virtual CrmAccionesCdbo IdcdboNavigation { get; set; }

    public virtual CrmAccionesIniciativa Iniciativa { get; set; }

    public virtual ICollection<CrmAccione> InverseCabeceraOrigen { get; set; } = new List<CrmAccione>();

    public virtual ICollection<CrmAccione> InverseCabeceraRecurrence { get; set; } = new List<CrmAccione>();

    public virtual CrmAccionesMedio Medio { get; set; }

    public virtual Cliente Persona { get; set; }

    public virtual CrmAccionesResultado Resultado { get; set; }

    public virtual CrmAccionesTipo TipoAccion { get; set; }
}
