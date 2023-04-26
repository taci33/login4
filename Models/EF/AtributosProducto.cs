using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class AtributosProducto
{
    public int IdatributoProducto { get; set; }

    public int? AtributoProductoId { get; set; }

    public string Nombre { get; set; }

    public string Prefijo { get; set; }

    public string Sufijo { get; set; }

    public int? Acabado { get; set; }

    public bool? Combina { get; set; }

    public bool LoadValuesInWizard { get; set; }

    public bool? ComponerNombre { get; set; }

    public bool Continuo { get; set; }

    public int? TipoId { get; set; }

    public virtual AtributosProducto AtributoProducto { get; set; }

    public virtual ICollection<AtributosCatalogo> AtributosCatalogos { get; set; } = new List<AtributosCatalogo>();

    public virtual CualificacionesAtributo CualificacionesAtributo { get; set; }

    public virtual ICollection<AtributosProducto> InverseAtributoProducto { get; set; } = new List<AtributosProducto>();

    public virtual OperacionesAtributo OperacionesAtributo { get; set; }

    public virtual ICollection<ProductosAtribsValore> ProductosAtribsValores { get; set; } = new List<ProductosAtribsValore>();

    public virtual AtributosTipo Tipo { get; set; }

    public virtual ICollection<ValoresProducto> ValoresProductos { get; set; } = new List<ValoresProducto>();
}
