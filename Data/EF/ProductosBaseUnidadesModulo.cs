using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class ProductosBaseUnidadesModulo
{
    public int ProductoBaseId { get; set; }

    public int MedidaId { get; set; }

    public int UnidadMedidaId { get; set; }

    public int ModuloGestionId { get; set; }

    public virtual ModulosGestion ModuloGestion { get; set; }

    public virtual UnidadesProductoBase UnidadesProductoBase { get; set; }
}
