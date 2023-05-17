using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class VPresupuestosCompra
{
    public int Idcabecera { get; set; }

    public string ReferenciaPersona { get; set; }

    public string Falta { get; set; }

    public decimal Total { get; set; }

    public string Observaciones { get; set; }

    public string NumeroPresupuesto { get; set; }

    public string Proveedor { get; set; }

    public string NombreDireccion { get; set; }

    public string Direccion { get; set; }

    public string CodigoPostal { get; set; }

    public string Localidad { get; set; }

    public string Provincia { get; set; }

    public string FormaPago { get; set; }

    public decimal? Iva { get; set; }

    public decimal? ImporteDescuento { get; set; }

    public decimal? BaseImponible { get; set; }

    public decimal? ImporteIva { get; set; }

    public decimal? TotalPresupuesto { get; set; }

    public decimal Descuento { get; set; }

    public string CifNif { get; set; }
}
