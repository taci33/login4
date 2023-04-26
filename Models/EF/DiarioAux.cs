﻿using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class DiarioAux
{
    public int EjercicioId { get; set; }

    public int Asiento { get; set; }

    public int Apunte { get; set; }

    public DateTime Fecha { get; set; }

    public string Cuenta { get; set; }

    public string Concepto { get; set; }

    public string Dh { get; set; }

    public double Importe { get; set; }

    public double? TipoIva { get; set; }

    public string Incidencia { get; set; }

    public bool Descuadre { get; set; }

    public string Factura { get; set; }

    public int? IvagrupoId { get; set; }

    public int? FacturaId { get; set; }

    public decimal? Re { get; set; }

    public decimal? BaseImponible { get; set; }

    public decimal? ImporteRe { get; set; }
}
