using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class RutasProduccion
{
    public int Idruta { get; set; }

    public string Nombre { get; set; }

    public string Notas { get; set; }

    public double TotalPrecioCoste { get; set; }

    public double TotalTiempoPreparacion { get; set; }

    public double TotalTiempoUnitario { get; set; }

    public virtual ICollection<Fase> Fases { get; set; } = new List<Fase>();
}
