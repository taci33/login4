using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class Proyecto
{
    public int Idcabecera { get; set; }

    public string Titulo { get; set; }

    public int? PersonaId { get; set; }

    public int EstadoId { get; set; }

    public string Anno { get; set; }

    public int? Numero { get; set; }

    public string Codigo { get; set; }

    public DateTime Falta { get; set; }

    public string Observaciones { get; set; }

    public int? EjercicioId { get; set; }

    public int? EmpleadoId { get; set; }

    public int? EmpresaId { get; set; }

    public string ReferenciaPersona { get; set; }

    public string SearchNameKeys { get; set; }

    public int? EmpleadoResponsableId { get; set; }

    public int? ProductoId { get; set; }

    public int? LoteId { get; set; }

    public virtual ICollection<AlbaranesCompra> AlbaranesCompras { get; set; } = new List<AlbaranesCompra>();

    public virtual ICollection<AlbaranesVentum> AlbaranesVenta { get; set; } = new List<AlbaranesVentum>();

    public virtual ICollection<DevolucionesVentum> DevolucionesVenta { get; set; } = new List<DevolucionesVentum>();

    public virtual Ejercicio Ejercicio { get; set; }

    public virtual Empleado Empleado { get; set; }

    public virtual Empleado EmpleadoResponsable { get; set; }

    public virtual ConfiguracionEmpresa Empresa { get; set; }

    public virtual ProyectosEstado Estado { get; set; }

    public virtual ICollection<FacturasCompra> FacturasCompras { get; set; } = new List<FacturasCompra>();

    public virtual ICollection<FacturasVentum> FacturasVenta { get; set; } = new List<FacturasVentum>();

    public virtual ICollection<LabBoletine> LabBoletines { get; set; } = new List<LabBoletine>();

    public virtual ICollection<LabOa> LabOas { get; set; } = new List<LabOa>();

    public virtual Lote Lote { get; set; }

    public virtual ICollection<Ope> Opes { get; set; } = new List<Ope>();

    public virtual ICollection<OrdenesFabricacion> OrdenesFabricacions { get; set; } = new List<OrdenesFabricacion>();

    public virtual ICollection<OrdenesSeriada> OrdenesSeriada { get; set; } = new List<OrdenesSeriada>();

    public virtual ICollection<PedidosCompra> PedidosCompras { get; set; } = new List<PedidosCompra>();

    public virtual ICollection<PedidosVentum> PedidosVenta { get; set; } = new List<PedidosVentum>();

    public virtual Cliente Persona { get; set; }

    public virtual ICollection<PresupuestosCompra> PresupuestosCompras { get; set; } = new List<PresupuestosCompra>();

    public virtual ICollection<PresupuestosVentum> PresupuestosVenta { get; set; } = new List<PresupuestosVentum>();

    public virtual Producto Producto { get; set; }

    public virtual ICollection<ProyectosDatosDinamico> ProyectosDatosDinamicos { get; set; } = new List<ProyectosDatosDinamico>();

    public virtual ICollection<SrvContrato> SrvContratos { get; set; } = new List<SrvContrato>();

    public virtual ICollection<SrvPresupuestosVentum> SrvPresupuestosVenta { get; set; } = new List<SrvPresupuestosVentum>();
}
