using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class DocumentosGestionAsiento
{
    public int DocumentoGestionId { get; set; }

    public int CabeceraId { get; set; }

    public int EjercicioId { get; set; }

    public int Asiento { get; set; }

    public virtual DocumentosGestion DocumentoGestion { get; set; }
}
