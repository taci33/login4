using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class Formulario
{
    public int Idformulario { get; set; }

    public int? CategoriaId { get; set; }

    public string Libreria { get; set; }

    public string Nombre { get; set; }

    public virtual FormulariosCategoria Categoria { get; set; }

    public virtual ICollection<DmnQueryForm> DmnQueryForms { get; set; } = new List<DmnQueryForm>();

    public virtual ICollection<DocumentosGestionTiposLineaTiposLinea> DocumentosGestionTiposLineaTiposLineas { get; set; } = new List<DocumentosGestionTiposLineaTiposLinea>();

    public virtual ICollection<DocumentosGestionTiposLinea> DocumentosGestionTiposLineas { get; set; } = new List<DocumentosGestionTiposLinea>();

    public virtual ICollection<DocumentosGestion> DocumentosGestions { get; set; } = new List<DocumentosGestion>();

    public virtual ICollection<GdEntidade> GdEntidades { get; set; } = new List<GdEntidade>();

    public virtual ICollection<GsEntidade> GsEntidades { get; set; } = new List<GsEntidade>();

    public virtual ICollection<GsGridsView> GsGridsViews { get; set; } = new List<GsGridsView>();

    public virtual ICollection<PartesFormulario> PartesFormularios { get; set; } = new List<PartesFormulario>();

    public virtual ICollection<PartesTipo> PartesTipos { get; set; } = new List<PartesTipo>();

    public virtual ICollection<PermisosAccione> PermisosAccioneClassFormIdp1Navigations { get; set; } = new List<PermisosAccione>();

    public virtual ICollection<PermisosAccione> PermisosAccioneClassFormIdp2Navigations { get; set; } = new List<PermisosAccione>();

    public virtual ICollection<PermisosAccione> PermisosAccioneFormularios { get; set; } = new List<PermisosAccione>();

    public virtual ICollection<ProductosTipo> ProductosTipos { get; set; } = new List<ProductosTipo>();
}
