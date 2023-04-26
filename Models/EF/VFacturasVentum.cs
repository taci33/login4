using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class VFacturasVentum
{
    public string NumeroFactura { get; set; }

    public int Idcabecera { get; set; }

    public string Titulo { get; set; }

    public int Tipo { get; set; }

    public int PersonaId { get; set; }

    public int SerieId { get; set; }

    public int? PersonaDireccionFacturaId { get; set; }

    public bool Entrega { get; set; }

    public int? PersonaDireccionEntregaId { get; set; }

    public int FormaPagoId { get; set; }

    public int EstadoId { get; set; }

    public string Anno { get; set; }

    public int? Numero { get; set; }

    public DateTime Falta { get; set; }

    public DateTime? Fentrega { get; set; }

    public decimal BaseImponible { get; set; }

    public decimal Total { get; set; }

    public decimal TotalCoste { get; set; }

    public string Observaciones { get; set; }

    public decimal Descuento { get; set; }

    public bool Contabilizada { get; set; }

    public bool Impresa { get; set; }

    public int? MedioId { get; set; }

    public string Cccadeudo { get; set; }

    public int? IvagrupoId { get; set; }

    public int PortesTipoId { get; set; }

    public decimal TotalPortes { get; set; }

    public decimal TotalFinanciacion { get; set; }

    public decimal TotalRetencion { get; set; }

    public string Cliente { get; set; }

    public string CifNif { get; set; }

    public string Direccion { get; set; }

    public string NombreDireccion { get; set; }

    public string CodigoPostal { get; set; }

    public string Localidad { get; set; }

    public string Provincia { get; set; }

    public string FormaPago { get; set; }

    public decimal? ImporteDescuento { get; set; }

    public decimal TotalFactura { get; set; }
}
