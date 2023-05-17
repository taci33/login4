using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class LabBoletine
{
    public int Idcabecera { get; set; }

    public long? Idcdbo { get; set; }

    public string Anno { get; set; }

    public int? Numero { get; set; }

    public string Titulo { get; set; }

    public string Codigo { get; set; }

    public int SerieId { get; set; }

    public DateTime Falta { get; set; }

    public int EstadoId { get; set; }

    public int PersonaId { get; set; }

    public int? ContactoId { get; set; }

    public int? PersonaDireccionFacturaId { get; set; }

    public bool Entrega { get; set; }

    public int? PersonaDireccionEntregaId { get; set; }

    public string RefCliente { get; set; }

    public DateTime? Fentrega { get; set; }

    public string Observaciones { get; set; }

    public int? EmpleadoId { get; set; }

    public int? EmpresaId { get; set; }

    public int? EjercicioId { get; set; }

    public DateTime? Frecepcion { get; set; }

    public int? TarifaId { get; set; }

    public int? IvagrupoId { get; set; }

    public int? ResponsableRecepcionId { get; set; }

    public int? PrioridadId { get; set; }

    public string CodificacionManual { get; set; }

    public DateTime? Fprevista { get; set; }

    public int? ProyectoId { get; set; }

    public int? AnalisisTipoId { get; set; }

    public int? PuntoMuestreo { get; set; }

    public bool? VisiblePuntoEntrega { get; set; }

    public string NotasInt { get; set; }

    public virtual ClientesContacto Contacto { get; set; }

    public virtual Ejercicio Ejercicio { get; set; }

    public virtual Empleado Empleado { get; set; }

    public virtual ConfiguracionEmpresa Empresa { get; set; }

    public virtual LabBoletinesEstado Estado { get; set; }

    public virtual LabBoletinesCdbo IdcdboNavigation { get; set; }

    public virtual Ivagrupo Ivagrupo { get; set; }

    public virtual ICollection<LabBoletinesDetalle> LabBoletinesDetalles { get; set; } = new List<LabBoletinesDetalle>();

    public virtual ICollection<LabBoletinesPoolDetalle> LabBoletinesPoolDetalles { get; set; } = new List<LabBoletinesPoolDetalle>();

    public virtual ICollection<LabBoletinesPool> LabBoletinesPools { get; set; } = new List<LabBoletinesPool>();

    public virtual LabPrioridade Prioridad { get; set; }

    public virtual Proyecto Proyecto { get; set; }

    public virtual Empleado ResponsableRecepcion { get; set; }

    public virtual Series Serie { get; set; }

    public virtual Tarifa Tarifa { get; set; }
}
