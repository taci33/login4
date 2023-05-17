using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class ComisionesOperacione
{
    public int Idoperacion { get; set; }

    public string Nombre { get; set; }

    public virtual ICollection<ComisionesDetalle> ComisionesDetalles { get; set; } = new List<ComisionesDetalle>();

    public virtual ICollection<LiquidacionesComercialDetalle> LiquidacionesComercialDetalles { get; set; } = new List<LiquidacionesComercialDetalle>();
}
