using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class LabOa
{
    public int Idcabecera { get; set; }

    public long? Idcdbo { get; set; }

    public int EjercicioId { get; set; }

    public string Anno { get; set; }

    public int? Numero { get; set; }

    public string Codigo { get; set; }

    public int? SerieId { get; set; }

    public int EstadoId { get; set; }

    public DateTime Falta { get; set; }

    public int PersonaId { get; set; }

    public int? PersonaDireccionEntregaId { get; set; }

    public string Titulo { get; set; }

    public string RefCliente { get; set; }

    public DateTime? Frecogida { get; set; }

    public DateTime? Frecepcion { get; set; }

    public DateTime? FinicioTeorico { get; set; }

    public DateTime? FfinTeorico { get; set; }

    public DateTime? FinicioReal { get; set; }

    public DateTime? FfinReal { get; set; }

    public string Observaciones { get; set; }

    public int? EmpleadoId { get; set; }

    public int? EmpresaId { get; set; }

    public DateTime? Fentrega { get; set; }

    public int? CabeceraOrigenId { get; set; }

    public int? LineaOrigenId { get; set; }

    public int? ProductoId { get; set; }

    public int? ResponsableId { get; set; }

    public int? PrioridadId { get; set; }

    public int? TarifaId { get; set; }

    public int Version { get; set; }

    public DateTime? Fvalidacion { get; set; }

    public int Edicion { get; set; }

    public bool Impresa { get; set; }

    public int? ProyectoId { get; set; }

    public int? PoolOrigenId { get; set; }

    public DateTime? FechaInforme { get; set; }

    public virtual Ejercicio Ejercicio { get; set; }

    public virtual Empleado Empleado { get; set; }

    public virtual ConfiguracionEmpresa Empresa { get; set; }

    public virtual LabOasEstado Estado { get; set; }

    public virtual LabOasCdbo IdcdboNavigation { get; set; }

    public virtual ICollection<LabOasDetalle> LabOasDetalles { get; set; } = new List<LabOasDetalle>();

    public virtual Cliente Persona { get; set; }

    public virtual LabPrioridade Prioridad { get; set; }

    public virtual Producto Producto { get; set; }

    public virtual Proyecto Proyecto { get; set; }

    public virtual Empleado Responsable { get; set; }

    public virtual Series Serie { get; set; }

    public virtual Tarifa Tarifa { get; set; }
}
