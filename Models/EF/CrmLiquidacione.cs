using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class CrmLiquidacione
{
    public int Idliquidacion { get; set; }

    public int CanjeId { get; set; }

    public DateTime FechaLiquidacion { get; set; }

    public DateTime? FechaCaducidad { get; set; }

    public decimal Vale { get; set; }

    public string Obsequio { get; set; }

    public bool Canjeado { get; set; }

    public int Puntos { get; set; }

    public int PersonaId { get; set; }

    public virtual CrmCanje Canje { get; set; }

    public virtual ICollection<CrmClientesPuntosCabecera> CrmClientesPuntosCabeceras { get; set; } = new List<CrmClientesPuntosCabecera>();

    public virtual Cliente Persona { get; set; }

    public virtual ICollection<Vale> Vales { get; set; } = new List<Vale>();
}
