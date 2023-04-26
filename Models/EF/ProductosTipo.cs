using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class ProductosTipo
{
    public int IdproductoTipo { get; set; }

    public int? FormularioId { get; set; }

    public string Nombre { get; set; }

    public bool GestStock { get; set; }

    public bool GestLotes { get; set; }

    public bool GestAtributos { get; set; }

    public bool GestFamilias { get; set; }

    public bool GestVentasMercaderias { get; set; }

    public bool GestTarifasVenta { get; set; }

    public bool GestFabricacion { get; set; }

    public string Codigo { get; set; }

    public int? AlmacenIdDef { get; set; }

    public int? UbicacionIdDef { get; set; }

    public int? MedidaId { get; set; }

    public int? UnidadMedidaId { get; set; }

    public double? Factor { get; set; }

    public decimal? UnidadAgrupacion { get; set; }

    public int? IvaclaseId { get; set; }

    public bool IsCompuesto { get; set; }

    public bool IsDetalleCompuesto { get; set; }

    public bool IsComponente { get; set; }

    public bool IsConjunto { get; set; }

    public bool? GestMedidas { get; set; }

    public bool GestAlmacen { get; set; }

    /// <summary>
    /// Valor por defecto para el campo Gest_Stock en Productos
    /// </summary>
    public bool DefaultGestStock { get; set; }

    /// <summary>
    /// Valor por defecto para el campo StockNegativo en Productos
    /// </summary>
    public bool DefaultStockNegativo { get; set; }

    /// <summary>
    /// Valor por defecto para el campo Gest_Almacen en Productos
    /// </summary>
    public bool DefaultGestAlmacen { get; set; }

    /// <summary>
    /// Valor por defecto para el campo Gest_Lotes en Productos
    /// </summary>
    public bool DefaultGestLotes { get; set; }

    /// <summary>
    /// Valor por defecto para el campo Gest_Margen en Productos
    /// </summary>
    public bool DefaultGestMargen { get; set; }

    /// <summary>
    /// Valor por defecto para el campo Margen en Productos
    /// </summary>
    public decimal DefaultMargen { get; set; }

    public int MargenTipoId { get; set; }

    public bool GestCorte { get; set; }

    public bool DefaultGestCorte { get; set; }

    public string CtaCompras { get; set; }

    public string CtaVentas { get; set; }

    public bool GestPreciosLotes { get; set; }

    public bool DefaultGestPreciosLotes { get; set; }

    public string WmTitle { get; set; }

    public string WmDescription { get; set; }

    public string WmKeyword { get; set; }

    public int DefaultMargenCompraId { get; set; }

    public bool IsConjuntoParametros { get; set; }

    public bool GestCorteMultiplos { get; set; }

    public bool GestCorteNumero { get; set; }

    public virtual AlmacenesUbicacione AlmacenesUbicacione { get; set; }

    public virtual ICollection<AlqAlquileresDescuentosGenerale> AlqAlquileresDescuentosGenerales { get; set; } = new List<AlqAlquileresDescuentosGenerale>();

    public virtual ICollection<AlqPresupuestosDescuentosGenerale> AlqPresupuestosDescuentosGenerales { get; set; } = new List<AlqPresupuestosDescuentosGenerale>();

    public virtual ICollection<ClientesDescuentosRoot> ClientesDescuentosRoots { get; set; } = new List<ClientesDescuentosRoot>();

    public virtual MargenesTipo DefaultMargenCompra { get; set; }

    public virtual ICollection<Familia> Familia { get; set; } = new List<Familia>();

    public virtual Formulario Formulario { get; set; }

    public virtual IvaClase Ivaclase { get; set; }

    public virtual MargenesTipo MargenTipo { get; set; }

    public virtual ICollection<PedidosVentaDescuentosGenerale> PedidosVentaDescuentosGenerales { get; set; } = new List<PedidosVentaDescuentosGenerale>();

    public virtual ICollection<PresupuestosVentaDescuentosGenerale> PresupuestosVentaDescuentosGenerales { get; set; } = new List<PresupuestosVentaDescuentosGenerale>();

    public virtual ICollection<Producto> Productos { get; set; } = new List<Producto>();

    public virtual ICollection<ProductosBase> ProductosBases { get; set; } = new List<ProductosBase>();

    public virtual ICollection<ProductosConjuntosComponente> ProductosConjuntosComponentes { get; set; } = new List<ProductosConjuntosComponente>();

    public virtual ICollection<ProveedoresDescuentosRoot> ProveedoresDescuentosRoots { get; set; } = new List<ProveedoresDescuentosRoot>();

    public virtual UnidadesMedidum UnidadesMedidum { get; set; }

    public virtual ICollection<DocumentosGestionTiposLinea> DocumentosGestionTiposLineas { get; set; } = new List<DocumentosGestionTiposLinea>();
}
