using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class DocumentosGestionTraspasosSetup
{
    public int DocumentoGestionOrigenId { get; set; }

    public int DocumentoGestionDestinoId { get; set; }

    public int DocumentoGestionStateOrigen { get; set; }

    public bool? GestCantidadServidaOrigen { get; set; }

    public int Tipo { get; set; }

    public bool CalculoPortesDestino { get; set; }

    public bool? CopiarObservaciones { get; set; }

    public virtual DocumentosGestion DocumentoGestionDestino { get; set; }

    public virtual DocumentosGestion DocumentoGestionOrigen { get; set; }
}
