using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class ProductosCompuestosPlantilla
{
    public int IdproductoCompuestoPlantilla { get; set; }

    public string Nombre { get; set; }

    /// <summary>
    /// Especifica si Genera Compuesto y en qué procesos (0 = No genera compuesto, 1 = Genera Compuesto siempre, 2 = Genera Compuesto en Alta manual de productos)
    /// </summary>
    public byte GeneraCompuestoEstadoId { get; set; }

    public virtual ICollection<ProductosCompuestosPlantillasComponente> ProductosCompuestosPlantillasComponentes { get; set; } = new List<ProductosCompuestosPlantillasComponente>();

    public virtual ICollection<ProductosCompuestosPlantillasLog> ProductosCompuestosPlantillasLogs { get; set; } = new List<ProductosCompuestosPlantillasLog>();
}
