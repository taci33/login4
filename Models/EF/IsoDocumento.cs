using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class IsoDocumento
{
    public int Iddocumento { get; set; }

    public string Nombre { get; set; }

    public string Identificacion { get; set; }

    public string Documento { get; set; }

    public int Revision { get; set; }

    public DateTime? FechaRevision { get; set; }

    public bool Externo { get; set; }

    public int? TipoRegistroId { get; set; }

    public string Modelo { get; set; }

    public string Descripcion { get; set; }

    public DateTime? FechaVigor { get; set; }

    public int? EmpleadoId { get; set; }

    public virtual Empleado Empleado { get; set; }

    public virtual ICollection<IsoRegistro> IsoRegistros { get; set; } = new List<IsoRegistro>();

    public virtual ICollection<IsoRequisito> IsoRequisitos { get; set; } = new List<IsoRequisito>();

    public virtual IsoTiposRegistro TipoRegistro { get; set; }

    public virtual ICollection<Puesto> Puestos { get; set; } = new List<Puesto>();
}
