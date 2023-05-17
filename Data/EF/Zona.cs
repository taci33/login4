using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class Zona
{
    public int Idzona { get; set; }

    public int AgenciaId { get; set; }

    public string Nombre { get; set; }

    public virtual ICollection<AgenciasTransporteTarifasDetalle> AgenciasTransporteTarifasDetalles { get; set; } = new List<AgenciasTransporteTarifasDetalle>();

    public virtual ICollection<Provincia> Provincia { get; set; } = new List<Provincia>();
}
