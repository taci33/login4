using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class LabAnalisisTipo
{
    public int Idtipo { get; set; }

    public int Codigo { get; set; }

    public string Grupo { get; set; }

    public string Descripcion { get; set; }

    public bool PuedeProducirIncumplimiento { get; set; }

    public virtual ICollection<LabBoletinesDetalle> LabBoletinesDetalles { get; set; } = new List<LabBoletinesDetalle>();
}
