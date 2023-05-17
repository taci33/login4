using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class ProductosCompuestosPlantillasComponente
{
    public int IdproductoCompuestoPlantillaComponente { get; set; }

    public int ProductoCompuestoPlantillaId { get; set; }

    public int ProductoId { get; set; }

    public string Descripcion { get; set; }

    public int MedidaId { get; set; }

    public int UnidadMedidaId { get; set; }

    public double Cantidad { get; set; }

    public virtual ProductosCompuestosPlantilla ProductoCompuestoPlantilla { get; set; }

    public virtual UnidadesProducto UnidadesProducto { get; set; }
}
