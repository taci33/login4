using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class ValesDetalle
{
    public int Idlinea { get; set; }

    public long? Idcdbo { get; set; }

    public int CabeceraId { get; set; }

    public int TicketId { get; set; }

    public decimal ImporteConsumido { get; set; }

    public string Obsequio { get; set; }

    public virtual Vale Cabecera { get; set; }

    public virtual ValesDetalleCdbo IdcdboNavigation { get; set; }

    public virtual Tpvticket Ticket { get; set; }
}
