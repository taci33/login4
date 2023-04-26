using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class CrmClientesPuntosCabecera
{
    public int Idcabecera { get; set; }

    public int PersonaId { get; set; }

    public int DocumentoGestionId { get; set; }

    public int DocumentoGestionCabeceraId { get; set; }

    public DateTime Falta { get; set; }

    public bool Liquidado { get; set; }

    public int? LiquidacionId { get; set; }

    public DateTime? FechaLiquidacion { get; set; }

    public virtual ICollection<CrmClientesPuntosDetalle> CrmClientesPuntosDetalles { get; set; } = new List<CrmClientesPuntosDetalle>();

    public virtual DocumentosGestion DocumentoGestion { get; set; }

    public virtual CrmLiquidacione Liquidacion { get; set; }

    public virtual CrmClientesPunto Persona { get; set; }
}
