using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class GsUsrGridsViewsCustomization
{
    public int IdusrGridViewCustomization { get; set; }

    public int? PersonaId { get; set; }

    public int GridViewId { get; set; }

    public string Descripcion { get; set; }

    public string RawData { get; set; }

    public virtual GsGridsView GridView { get; set; }

    public virtual Empleado Persona { get; set; }
}
