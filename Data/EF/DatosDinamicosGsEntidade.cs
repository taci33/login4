using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class DatosDinamicosGsEntidade
{
    public int EntidadId { get; set; }

    /// <summary>
    /// Determina la CategorÝa en la que aparecerß la Entidad (0 = Documentos de Gesti¾n, 1 = Productos, 2 = Clientes)
    /// </summary>
    public int CategoryId { get; set; }

    public bool Enabled { get; set; }

    public virtual ICollection<DatosDinamicosGsEntidadesDef> DatosDinamicosGsEntidadesDefs { get; set; } = new List<DatosDinamicosGsEntidadesDef>();

    public virtual GsEntidade Entidad { get; set; }
}
