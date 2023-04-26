using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class LabBoletinesPool
{
    public int Idpool { get; set; }

    public int CabeceraId { get; set; }

    public int Numero { get; set; }

    public string Descripcion { get; set; }

    public double Cantidad { get; set; }

    public int EstadoId { get; set; }

    public DateTime? Fprevista { get; set; }

    public string ReferenciaInterna { get; set; }

    public string ReferenciaPersona { get; set; }

    public string IdentificacionMuestra { get; set; }

    public virtual LabBoletine Cabecera { get; set; }

    public virtual LabBoletinesEstado Estado { get; set; }

    public virtual ICollection<LabBoletinesPoolDetalle> LabBoletinesPoolDetalles { get; set; } = new List<LabBoletinesPoolDetalle>();
}
