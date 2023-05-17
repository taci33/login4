using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class DocumentosGestionMargenesClafe
{
    public int DocumentoGestionId { get; set; }

    public int CabeceraId { get; set; }

    public int MargenClaveId { get; set; }

    public decimal Margen { get; set; }

    public virtual DocumentosGestion DocumentoGestion { get; set; }

    public virtual MargenesClafe MargenClave { get; set; }
}
