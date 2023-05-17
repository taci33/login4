using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class TesoreriaApunteTipo
{
    public int IdtipoApunte { get; set; }

    public string Tipo { get; set; }

    public string TableNameRelated { get; set; }

    public string TableNameRelatedDestinatario { get; set; }

    public string Descripcion { get; set; }

    public virtual ICollection<TesoreriaApunte> TesoreriaApuntes { get; set; } = new List<TesoreriaApunte>();
}
