using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class VPartesOf
{
    public int Idcabecera { get; set; }

    public string Codigo { get; set; }

    public DateTime FechaParte { get; set; }

    public int Idparte { get; set; }

    public string NumeroPedido { get; set; }

    public string NombreCliente { get; set; }

    public decimal Cantidad { get; set; }

    public DateTime? FechaImputacion { get; set; }

    public string Observaciones { get; set; }

    public string Recurso { get; set; }

    public DateTime? PartesFechaFinPartesFe { get; set; }

    public int? CentroTipoId { get; set; }
}
