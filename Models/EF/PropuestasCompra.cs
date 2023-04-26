using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class PropuestasCompra
{
    public int Idcabecera { get; set; }

    public string Titulo { get; set; }

    public DateTime Falta { get; set; }

    public int DocumentoOrigenId { get; set; }

    public int CabeceraOrigenId { get; set; }

    public bool Ejecutada { get; set; }

    public virtual DocumentosGestion DocumentoOrigen { get; set; }

    public virtual ICollection<PropuestasCompraDetalle> PropuestasCompraDetalles { get; set; } = new List<PropuestasCompraDetalle>();
}
