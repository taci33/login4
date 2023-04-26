using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class ProductosCodigosBarra
{
    public int IdproductoCodigoBarras { get; set; }

    public int ProductoId { get; set; }

    public int MedidaId { get; set; }

    public int UnidadMedidaId { get; set; }

    public string CodigoBarras { get; set; }

    public virtual UnidadesMedidum UnidadesMedidum { get; set; }

    public virtual UnidadesProducto UnidadesProducto { get; set; }
}
