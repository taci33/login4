using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class LiquidacionesComercialEstado
{
    public int Idestado { get; set; }

    public string Nombre { get; set; }

    public string FontColor { get; set; }

    public bool Traspaso { get; set; }

    public bool CantidadPendiente { get; set; }

    public bool? AllowModify { get; set; }

    public virtual ICollection<LiquidacionesComercialDetalle> LiquidacionesComercialDetalles { get; set; } = new List<LiquidacionesComercialDetalle>();

    public virtual ICollection<LiquidacionesComercial> LiquidacionesComercials { get; set; } = new List<LiquidacionesComercial>();
}
