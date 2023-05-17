using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class SrvContratosPlanificacion
{
    public int Idplanificacion { get; set; }

    public int CabeceraId { get; set; }

    public int LineaId { get; set; }

    public int? Numero { get; set; }

    public int Revision { get; set; }

    public string Codigo { get; set; }

    public DateTime? Fprevista { get; set; }

    public bool FechaFija { get; set; }

    public int? CabeceraOfidRelated { get; set; }

    public virtual SrvContrato Cabecera { get; set; }
}
