using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class AgenciasTransporteTarifasDetalle
{
    public int IdtarifaAgenciaDetalle { get; set; }

    public int ZonaId { get; set; }

    public int TarifaAgenciaId { get; set; }

    public double PesoDesde { get; set; }

    public int UnidadMedidaId { get; set; }

    public double Precio { get; set; }

    public int? AgenciaId { get; set; }

    public virtual AgenciasTransporteTarifa AgenciasTransporteTarifa { get; set; }

    public virtual UnidadesMedidum UnidadMedida { get; set; }

    public virtual Zona Zona { get; set; }
}
