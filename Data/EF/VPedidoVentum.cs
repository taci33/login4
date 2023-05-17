using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class VPedidoVentum
{
    public string NumeroPedido { get; set; }

    public int Idcabecera { get; set; }

    public string Titulo { get; set; }

    public int? Tipo { get; set; }

    public int PersonaId { get; set; }

    public int SerieId { get; set; }

    public int? PersonaDireccionId { get; set; }

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

    public int? IvagrupoId { get; set; }

    public string Cliente { get; set; }

    public string CifNif { get; set; }

    public string Direccion { get; set; }

    public string NombreDireccion { get; set; }

    public string CodigoPostal { get; set; }

    public string Localidad { get; set; }

    public string Provincia { get; set; }
}
