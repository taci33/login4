using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class GsGridDefinition
{
    /// <summary>
    /// ID autonumerico debido a que se usará el código para localizar un registro (UIX)
    /// </summary>
    public int IdgridDefinition { get; set; }

    public int? GridDefinitionId { get; set; }

    public int EntidadId { get; set; }

    /// <summary>
    /// Formato: PrefijoEntidad_DDDD, del 3000 en adelante reservados para el usuario
    /// </summary>
    public string Codigo { get; set; }

    public string Descripcion { get; set; }

    public virtual ICollection<DmnDataSet> DmnDataSets { get; set; } = new List<DmnDataSet>();

    public virtual GsEntidade Entidad { get; set; }

    public virtual GsGridDefinition GridDefinition { get; set; }

    public virtual ICollection<GsGridColumn> GsGridColumns { get; set; } = new List<GsGridColumn>();

    public virtual ICollection<GsGridDefinition> InverseGridDefinition { get; set; } = new List<GsGridDefinition>();
}
