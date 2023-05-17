using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class Vale
{
    public int Idcabecera { get; set; }

    public long? Idcdbo { get; set; }

    public int PersonaId { get; set; }

    public int EstadoId { get; set; }

    public int? EjercicioId { get; set; }

    public string Anno { get; set; }

    public int? Numero { get; set; }

    public string Codigo { get; set; }

    public int OrigenId { get; set; }

    public int? TicketId { get; set; }

    public int? LiquidacionId { get; set; }

    public DateTime Falta { get; set; }

    public DateTime? Fcaducidad { get; set; }

    public DateTime? Fconsumo { get; set; }

    public decimal ImporteTotal { get; set; }

    public decimal ImporteConsumido { get; set; }

    public string Obsequio { get; set; }

    public int? ProductoObsequioId { get; set; }

    public int? EmpleadoId { get; set; }

    public int? EmpresaId { get; set; }

    public int? TicketDetalleId { get; set; }

    public virtual Ejercicio Ejercicio { get; set; }

    public virtual Empleado Empleado { get; set; }

    public virtual ConfiguracionEmpresa Empresa { get; set; }

    public virtual ValesEstado Estado { get; set; }

    public virtual ValesCdbo IdcdboNavigation { get; set; }

    public virtual CrmLiquidacione Liquidacion { get; set; }

    public virtual ValesOrigene Origen { get; set; }

    public virtual Cliente Persona { get; set; }

    public virtual Producto ProductoObsequio { get; set; }

    public virtual Tpvticket Ticket { get; set; }

    public virtual ICollection<ValesDetalle> ValesDetalles { get; set; } = new List<ValesDetalle>();
}
