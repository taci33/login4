using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class ReservasStock
{
    public int Idcabecera { get; set; }

    public int DgorigenId { get; set; }

    public int CabeceraOrigenId { get; set; }

    public DateTime Falta { get; set; }

    public int PersonaId { get; set; }

    public int? EmpleadoId { get; set; }

    public int? EmpresaId { get; set; }

    public virtual ICollection<ReservasStockDetalle> ReservasStockDetalles { get; set; } = new List<ReservasStockDetalle>();
}
