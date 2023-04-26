using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class MaquinasConsumo
{
    public int Idconsumo { get; set; }

    public int EmpleadoId { get; set; }

    public int? MaquinaId { get; set; }

    public DateTime Falta { get; set; }

    public DateTime FechaConsumo { get; set; }

    public int TipoConsumo { get; set; }

    public double NumeroLitros { get; set; }

    public double? NumeroKilometros { get; set; }

    public int? FacturaCompraId { get; set; }

    public int? FacturaCompraDetalleId { get; set; }
}
