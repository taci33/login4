using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class Familia
{
    public int Idfamilia { get; set; }

    public int? FamiliaId { get; set; }

    public int? CatalogoAtributoId { get; set; }

    public int ProductoTipoId { get; set; }

    public string Nombre { get; set; }

    public string Descripcion { get; set; }

    public string CtaCompras { get; set; }

    public string CtaVentas { get; set; }

    public int? CentroCosteId { get; set; }

    public int Orden { get; set; }

    public string WmTitle { get; set; }

    public string WmDescription { get; set; }

    public string WmKeyword { get; set; }

    public bool? Imprimir { get; set; }

    public virtual CatalogosAtributo CatalogoAtributo { get; set; }

    public virtual CtaCentroCoste CentroCoste { get; set; }

    public virtual ICollection<ClientesDescuento> ClientesDescuentos { get; set; } = new List<ClientesDescuento>();

    public virtual Familia FamiliaNavigation { get; set; }

    public virtual ICollection<FamiliasDatosDinamico> FamiliasDatosDinamicos { get; set; } = new List<FamiliasDatosDinamico>();

    public virtual ICollection<Familia> InverseFamiliaNavigation { get; set; } = new List<Familia>();

    public virtual ProductosTipo ProductoTipo { get; set; }

    public virtual ICollection<Producto> Productos { get; set; } = new List<Producto>();

    public virtual ICollection<ProductosBase> ProductosBases { get; set; } = new List<ProductosBase>();

    public virtual ICollection<ProveedoresDescuento> ProveedoresDescuentos { get; set; } = new List<ProveedoresDescuento>();

    public virtual ICollection<SyncConnection> Connections { get; set; } = new List<SyncConnection>();
}
