using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class OrdenesSeriada
{
    public int Idcabecera { get; set; }

    public string Codigo { get; set; }

    public string Anno { get; set; }

    public int? Numero { get; set; }

    public int EstadoId { get; set; }

    public int TipoId { get; set; }

    public int OrigenId { get; set; }

    public int PrioridadId { get; set; }

    public DateTime Falta { get; set; }

    public string Titulo { get; set; }

    public int? DocumentoGestionOrigenId { get; set; }

    public int? CabeceraOrigenId { get; set; }

    public int? LineaOrigenId { get; set; }

    public int? PersonaId { get; set; }

    public int? ConjuntoId { get; set; }

    public double CantidadTeorica { get; set; }

    public double CantidadRechazada { get; set; }

    public double CantidadReal { get; set; }

    public int? MedidaId { get; set; }

    public int? UnidadMedidaId { get; set; }

    public DateTime? FechaInicioTeorica { get; set; }

    public DateTime? FechaFinTeorica { get; set; }

    public DateTime? FechaNecesidad { get; set; }

    public DateTime? FechaInicioReal { get; set; }

    public DateTime? FechaFinReal { get; set; }

    public decimal TotalCosteTeorico { get; set; }

    public decimal MargenTeorico { get; set; }

    public decimal TotalVentaTeorico { get; set; }

    public decimal TotalCosteReal { get; set; }

    public decimal MargenReal { get; set; }

    public decimal TotalVentaReal { get; set; }

    public string Observaciones { get; set; }

    public int? IvagrupoId { get; set; }

    public int? EjercicioId { get; set; }

    public int? SerieId { get; set; }

    public int? EmpleadoId { get; set; }

    public int? EmpresaId { get; set; }

    public int? ProyectoId { get; set; }

    public int? EmpleadoResponsableId { get; set; }

    public int? RutaId { get; set; }

    public bool Impresa { get; set; }

    public virtual ProductosConjunto Conjunto { get; set; }

    public virtual Ejercicio Ejercicio { get; set; }

    public virtual Empleado Empleado { get; set; }

    public virtual Empleado EmpleadoResponsable { get; set; }

    public virtual ConfiguracionEmpresa Empresa { get; set; }

    public virtual OrdenesSeriadasEstado Estado { get; set; }

    public virtual ICollection<FichajesParte> FichajesPartes { get; set; } = new List<FichajesParte>();

    public virtual Ivagrupo Ivagrupo { get; set; }

    public virtual Medida Medida { get; set; }

    public virtual ICollection<OpesDetalle> OpesDetalles { get; set; } = new List<OpesDetalle>();

    public virtual ICollection<OrdenesSeriadasDatosDinamico> OrdenesSeriadasDatosDinamicos { get; set; } = new List<OrdenesSeriadasDatosDinamico>();

    public virtual ICollection<OrdenesSeriadasDetalle> OrdenesSeriadasDetalles { get; set; } = new List<OrdenesSeriadasDetalle>();

    public virtual OrdenesFabricacionOrigene Origen { get; set; }

    public virtual Cliente Persona { get; set; }

    public virtual OrdenesFabricacionPrioridade Prioridad { get; set; }

    public virtual Proyecto Proyecto { get; set; }

    public virtual Series Serie { get; set; }

    public virtual OrdenesFabricacionTipo Tipo { get; set; }

    public virtual UnidadesMedidum UnidadMedida { get; set; }
}
