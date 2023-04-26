using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class DmnQueryForm
{
    public int IdqueryForm { get; set; }

    /// <summary>
    /// Mantenido por Soltic &gt; Formato: Prefijo_DDDD, del 3000 en adelante reservados para el usuario
    /// </summary>
    public string Codigo { get; set; }

    public int FormularioId { get; set; }

    public virtual ICollection<DmnDataSet> DmnDataSets { get; set; } = new List<DmnDataSet>();

    public virtual Formulario Formulario { get; set; }
}
