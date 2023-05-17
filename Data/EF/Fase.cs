using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class Fase
{
    public int Idfase { get; set; }

    public int RutaId { get; set; }

    public int Orden { get; set; }

    public int? FaseId { get; set; }

    public string Nombre { get; set; }

    public int OperacionId { get; set; }

    public double TotalTiempoUnitario { get; set; }

    public double TotalTiempoPreparacion { get; set; }

    public bool Solapamiento { get; set; }

    public decimal FactorSolapamiento { get; set; }

    public string Notas { get; set; }

    public double TotalPrecioCoste { get; set; }

    public double TotalTiempoProductividad { get; set; }

    public virtual Fase FaseNavigation { get; set; }

    public virtual ICollection<FasesCentro> FasesCentros { get; set; } = new List<FasesCentro>();

    public virtual ICollection<Fase> InverseFaseNavigation { get; set; } = new List<Fase>();

    public virtual Operacione Operacion { get; set; }

    public virtual RutasProduccion Ruta { get; set; }
}
