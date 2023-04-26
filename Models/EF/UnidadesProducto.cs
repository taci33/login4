using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class UnidadesProducto
{
    public int ProductoId { get; set; }

    public int MedidaId { get; set; }

    public int UnidadMedidaId { get; set; }

    public double Factor { get; set; }

    public decimal UnidadAgrupacion { get; set; }

    public virtual Medida Medida { get; set; }

    public virtual ICollection<MovimientosAlmacenDetalle> MovimientosAlmacenDetalles { get; set; } = new List<MovimientosAlmacenDetalle>();

    public virtual Producto Producto { get; set; }

    public virtual ICollection<ProductosCodigosBarra> ProductosCodigosBarras { get; set; } = new List<ProductosCodigosBarra>();

    public virtual ICollection<ProductosCompuestosPlantillasComponente> ProductosCompuestosPlantillasComponentes { get; set; } = new List<ProductosCompuestosPlantillasComponente>();

    public virtual ICollection<ProductosConjunto> ProductosConjuntos { get; set; } = new List<ProductosConjunto>();

    public virtual ICollection<ProductosConjuntosComponente> ProductosConjuntosComponentes { get; set; } = new List<ProductosConjuntosComponente>();

    public virtual ICollection<ProductosUnidadesModulo> ProductosUnidadesModulos { get; set; } = new List<ProductosUnidadesModulo>();

    public virtual UnidadesMedidum UnidadMedida { get; set; }
}
