using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class Lote
{
    public int Idlote { get; set; }

    public int ProductoId { get; set; }

    public long? Idcdbo { get; set; }

    public string Numero { get; set; }

    public int? ClienteId { get; set; }

    public int? ProveedorId { get; set; }

    public string ReferenciaProveedor { get; set; }

    public string Nombre { get; set; }

    public DateTime Falta { get; set; }

    public DateTime? Fbaja { get; set; }

    public int EstadoId { get; set; }

    public double StockMin { get; set; }

    public double StockMax { get; set; }

    public double StockActual { get; set; }

    public double StockPedido { get; set; }

    public bool StockNegativo { get; set; }

    public double PrecioCompra { get; set; }

    public double PrecioCompraMedio { get; set; }

    public double PrecioVenta { get; set; }

    public double PrecioVentaMedio { get; set; }

    public bool LoteMaestro { get; set; }

    public double StockDisponible { get; set; }

    public double StockVirtual { get; set; }

    public double StockReservado { get; set; }

    public decimal DtoCompraUltima { get; set; }

    public double PrecioCompraSinDtoUltima { get; set; }

    public DateTime? FechaCaducidad { get; set; }

    public string Notas { get; set; }

    public double CantidadEnvase { get; set; }

    public virtual ICollection<BienesAmortizable> BienesAmortizables { get; set; } = new List<BienesAmortizable>();

    public virtual Cliente Cliente { get; set; }

    public virtual ICollection<DgdUbicacione> DgdUbicaciones { get; set; } = new List<DgdUbicacione>();

    public virtual ICollection<DocumentosGestionDetalleUbicacione> DocumentosGestionDetalleUbicaciones { get; set; } = new List<DocumentosGestionDetalleUbicacione>();

    public virtual LotesEstado Estado { get; set; }

    public virtual LotesCdbo IdcdboNavigation { get; set; }

    public virtual ICollection<LotesTraza> LotesTrazaLoteIddestinoNavigations { get; set; } = new List<LotesTraza>();

    public virtual ICollection<LotesTraza> LotesTrazaLoteIdorigenNavigations { get; set; } = new List<LotesTraza>();

    public virtual ICollection<MovimientosAlmacenDetalle> MovimientosAlmacenDetalles { get; set; } = new List<MovimientosAlmacenDetalle>();

    public virtual ICollection<MovimientosAlmacenSaldo> MovimientosAlmacenSaldos { get; set; } = new List<MovimientosAlmacenSaldo>();

    public virtual ICollection<OpesDetalle> OpesDetalles { get; set; } = new List<OpesDetalle>();

    public virtual ICollection<OrdenesSeriadasDetalle> OrdenesSeriadasDetalles { get; set; } = new List<OrdenesSeriadasDetalle>();

    public virtual ICollection<Parte> Partes { get; set; } = new List<Parte>();

    public virtual Producto Producto { get; set; }

    public virtual ICollection<ProductosAlmacen> ProductosAlmacens { get; set; } = new List<ProductosAlmacen>();

    public virtual ICollection<ProductosConjuntosComponente> ProductosConjuntosComponentes { get; set; } = new List<ProductosConjuntosComponente>();

    public virtual ICollection<PropuestasCompraDetalle> PropuestasCompraDetalles { get; set; } = new List<PropuestasCompraDetalle>();

    public virtual Proveedore Proveedor { get; set; }

    public virtual ICollection<Proyecto> Proyectos { get; set; } = new List<Proyecto>();

    public virtual ICollection<RegularizacionesAlmacen> RegularizacionesAlmacens { get; set; } = new List<RegularizacionesAlmacen>();

    public virtual ICollection<ReservasStockDetalle> ReservasStockDetalles { get; set; } = new List<ReservasStockDetalle>();

    public virtual ICollection<TpvticketsDetalle> TpvticketsDetalles { get; set; } = new List<TpvticketsDetalle>();
}
