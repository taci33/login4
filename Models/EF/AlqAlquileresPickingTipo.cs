using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class AlqAlquileresPickingTipo
{
    public int Idtipo { get; set; }

    public string Nombre { get; set; }

    public virtual ICollection<AlqAlquileresPicking> AlqAlquileresPickings { get; set; } = new List<AlqAlquileresPicking>();
}
