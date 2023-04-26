using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class CrmCanje
{
    public int Idcanje { get; set; }

    public string Nombre { get; set; }

    public DateTime FechaInicio { get; set; }

    public DateTime FechaFin { get; set; }

    public int Tipo { get; set; }

    public decimal ValorFijo { get; set; }

    public int? TiempoCaducidad { get; set; }

    public virtual ICollection<CrmCanjesDetalle> CrmCanjesDetalles { get; set; } = new List<CrmCanjesDetalle>();

    public virtual ICollection<CrmLiquidacione> CrmLiquidaciones { get; set; } = new List<CrmLiquidacione>();
}
