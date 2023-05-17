using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class Fichaje
{
    public int Idcabecera { get; set; }

    public int? CabeceraId { get; set; }

    public int PersonaId { get; set; }

    public int? TurnoId { get; set; }

    public DateTime Falta { get; set; }

    public DateTime FaltaInt { get; set; }

    public int EstadoId { get; set; }

    public bool Modificado { get; set; }

    public double TotalHoras { get; set; }

    public virtual Fichaje Cabecera { get; set; }

    public virtual FichajesEstado Estado { get; set; }

    public virtual ICollection<FichajesDetalle> FichajesDetalles { get; set; } = new List<FichajesDetalle>();

    public virtual ICollection<Fichaje> InverseCabecera { get; set; } = new List<Fichaje>();

    public virtual Empleado Persona { get; set; }

    public virtual Turno Turno { get; set; }
}
