using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class Tarifa
{
    public int Idtarifa { get; set; }

    public string Nombre { get; set; }

    /// <summary>
    /// Determina si la Tarifa se aplica a aquellos clientes que no tienen Tarifa especifica
    /// </summary>
    public bool General { get; set; }

    public DateTime? Finicio { get; set; }

    public DateTime? Ffin { get; set; }

    public string Descripcion { get; set; }

    public virtual ICollection<LabBoletine> LabBoletines { get; set; } = new List<LabBoletine>();

    public virtual ICollection<LabBoletinesDetalle> LabBoletinesDetalles { get; set; } = new List<LabBoletinesDetalle>();

    public virtual ICollection<LabOa> LabOas { get; set; } = new List<LabOa>();

    public virtual ICollection<TarifasDetalle> TarifasDetalles { get; set; } = new List<TarifasDetalle>();

    public virtual ICollection<Tpvticket> Tpvtickets { get; set; } = new List<Tpvticket>();
}
