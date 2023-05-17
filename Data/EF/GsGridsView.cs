using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class GsGridsView
{
    public int IdgridView { get; set; }

    public int FormularioId { get; set; }

    public string GridViewName { get; set; }

    public int EntidadId { get; set; }

    public virtual GsEntidade Entidad { get; set; }

    public virtual Formulario Formulario { get; set; }

    public virtual ICollection<GsUsrGridsViewsCustomization> GsUsrGridsViewsCustomizations { get; set; } = new List<GsUsrGridsViewsCustomization>();
}
