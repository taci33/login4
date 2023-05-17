using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class ProductosUnidadesModulo
{
    public int ProductoId { get; set; }

    public int MedidaId { get; set; }

    public int UnidadMedidaId { get; set; }

    public int ModuloGestionId { get; set; }

    public virtual ModulosGestion ModuloGestion { get; set; }

    public virtual UnidadesProducto UnidadesProducto { get; set; }
}
