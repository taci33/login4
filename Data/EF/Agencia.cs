using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class Agencia
{
    public string Idagencia { get; set; }

    public string CodigoEntidad { get; set; }

    public string Nombre { get; set; }

    public virtual Entidade CodigoEntidadNavigation { get; set; }
}
