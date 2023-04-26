using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class Localidade
{
    public int Idlocalidad { get; set; }

    public int? ProvinciaId { get; set; }

    public string Nombre { get; set; }

    public int? ComarcaId { get; set; }

    public virtual ICollection<ClientesDireccione> ClientesDirecciones { get; set; } = new List<ClientesDireccione>();

    public virtual Comarca Comarca { get; set; }

    public virtual ICollection<EmpleadosDireccione> EmpleadosDirecciones { get; set; } = new List<EmpleadosDireccione>();

    public virtual Provincia Provincia { get; set; }
}
