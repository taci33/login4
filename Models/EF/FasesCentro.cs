using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class FasesCentro
{
    public int IdfaseCentro { get; set; }

    public int FaseId { get; set; }

    public int CentroId { get; set; }

    public int? ProductoId { get; set; }

    public double TiempoUnitario { get; set; }

    public double TiempoPreparacion { get; set; }

    public string Notas { get; set; }

    public double PrecioCoste { get; set; }

    public virtual CentrosTrabajo Centro { get; set; }

    public virtual Fase Fase { get; set; }

    public virtual Producto Producto { get; set; }
}
