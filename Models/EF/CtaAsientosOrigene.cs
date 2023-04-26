using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class CtaAsientosOrigene
{
    public int Idorigen { get; set; }

    public string Nombre { get; set; }

    public int? DocumentoGestionId { get; set; }

    public string TableName { get; set; }

    public virtual ICollection<Diario> Diarios { get; set; } = new List<Diario>();

    public virtual DocumentosGestion DocumentoGestion { get; set; }
}
