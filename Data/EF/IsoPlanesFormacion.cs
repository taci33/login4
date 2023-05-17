using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class IsoPlanesFormacion
{
    public int IdplanFormacion { get; set; }

    public string Nombre { get; set; }

    public string Descripcion { get; set; }

    public string Personal { get; set; }

    public string Impartido { get; set; }

    public int? Duracion { get; set; }

    public DateTime? FechaInicio { get; set; }

    public DateTime? FechaFin { get; set; }

    public bool Eficaz { get; set; }

    public virtual ICollection<IsoCriteriosEficacium> IsoCriteriosEficacia { get; set; } = new List<IsoCriteriosEficacium>();

    public virtual ICollection<IsoCurso> IsoCursos { get; set; } = new List<IsoCurso>();
}
