using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class CdboPedidosPendientesImportar
{
    public int Idpedido { get; set; }

    public string Referencia { get; set; }

    public string Nombre { get; set; }

    public string Email { get; set; }

    public string MetodoPago { get; set; }

    public double? Importe { get; set; }
}
