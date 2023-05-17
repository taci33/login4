using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class FichajesDetalle
{
    public int Idlinea { get; set; }

    public int CabeceraId { get; set; }

    public int? LineaId { get; set; }

    public int TipoId { get; set; }

    public DateTime FechaHora { get; set; }

    public DateTime FechaHoraInt { get; set; }

    public string Observaciones { get; set; }

    public DateTime FechaHoraOperario { get; set; }

    public virtual Fichaje Cabecera { get; set; }

    public virtual ICollection<FichajesParte> FichajesPartes { get; set; } = new List<FichajesParte>();

    public virtual ICollection<FichajesDetalle> InverseLinea { get; set; } = new List<FichajesDetalle>();

    public virtual FichajesDetalle Linea { get; set; }

    public virtual FichajesTipo Tipo { get; set; }
}
