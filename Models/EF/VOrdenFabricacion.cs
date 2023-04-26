using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class VOrdenFabricacion
{
    public int Idcabecera { get; set; }

    public string Codigo { get; set; }

    public string Titulo { get; set; }

    public int? PersonaId { get; set; }

    public string Anno { get; set; }

    public int? Numero { get; set; }

    public int EstadoId { get; set; }

    public int TipoId { get; set; }

    public int? OrigenId { get; set; }

    public int PrioridadId { get; set; }

    public DateTime Falta { get; set; }

    public DateTime? FechaInicio { get; set; }

    public DateTime? FechaPrevista { get; set; }

    public DateTime? FechaFin { get; set; }

    public decimal TotalVenta { get; set; }

    public decimal TotalCoste { get; set; }

    public decimal TotalCosteReal { get; set; }

    public string Observaciones { get; set; }

    public decimal Descuento { get; set; }

    public decimal? Margen { get; set; }

    public decimal? MargenReal { get; set; }

    public string Estado { get; set; }

    public string Tipo { get; set; }

    public string Prioridad { get; set; }

    public string Origen { get; set; }

    public int? Idpersona { get; set; }

    public string NombreCliente { get; set; }

    public int? PedidoVentaId { get; set; }

    public string NumeroPedido { get; set; }
}
