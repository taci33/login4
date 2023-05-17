using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class ProductosCompuestosPlantillasLog
{
    public int Idlog { get; set; }

    /// <summary>
    /// IDProducto que llama al proceso
    /// </summary>
    public int ProductoGeneratorId { get; set; }

    /// <summary>
    /// IDPlantilla que tiene asociado el ProductoGeneratorID en el momento de la llamada al proceso de generaci¾n de compuestos
    /// </summary>
    public int ProductoCompuestoPlantillaId { get; set; }

    /// <summary>
    /// IDProductoCompuesto que se genera una vez llamado al proceso
    /// </summary>
    public int ProductoCompuestoId { get; set; }

    public virtual ProductosCompuestosPlantilla ProductoCompuestoPlantilla { get; set; }

    public virtual Producto ProductoGenerator { get; set; }
}
