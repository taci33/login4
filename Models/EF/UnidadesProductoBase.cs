using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class UnidadesProductoBase
{
    public int ProductoBaseId { get; set; }

    public int MedidaId { get; set; }

    public int UnidadMedidaId { get; set; }

    public double Factor { get; set; }

    public decimal UnidadAgrupacion { get; set; }

    public virtual Medida Medida { get; set; }

    public virtual ProductosBase ProductoBase { get; set; }

    public virtual ICollection<ProductosBaseUnidadesModulo> ProductosBaseUnidadesModulos { get; set; } = new List<ProductosBaseUnidadesModulo>();

    public virtual UnidadesMedidum UnidadMedida { get; set; }
}
