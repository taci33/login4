using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class ProductosCliente
{
    public int ProductoId { get; set; }

    public int PersonaId { get; set; }

    public string RefPersona { get; set; }

    public double PrecioTarifa { get; set; }

    public bool Tarifa { get; set; }

    public decimal Descuento { get; set; }

    public int CalculoTipo { get; set; }

    public string Notas { get; set; }

    public virtual Producto Producto { get; set; }
}
