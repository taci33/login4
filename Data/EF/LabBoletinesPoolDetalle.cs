using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class LabBoletinesPoolDetalle
{
    public int Idrelacion { get; set; }

    public int CabeceraId { get; set; }

    public int PoolId { get; set; }

    public int DetalleId { get; set; }

    public virtual LabBoletine Cabecera { get; set; }

    public virtual LabBoletinesDetalle Detalle { get; set; }

    public virtual LabBoletinesPool Pool { get; set; }
}
