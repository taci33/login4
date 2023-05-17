using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class IsoRegistro
{
    public int Idregistro { get; set; }

    public string Nombre { get; set; }

    public string Descripcion { get; set; }

    public int Revision { get; set; }

    public DateTime? FechaRevision { get; set; }

    public string Formato { get; set; }

    public int? DocumentoId { get; set; }

    public int? TipoRegistroId { get; set; }

    public int? EmpleadoId { get; set; }

    public string TiempoConservacion { get; set; }

    public string Destruccion { get; set; }

    public virtual IsoDocumento Documento { get; set; }

    public virtual Empleado Empleado { get; set; }

    public virtual IsoTiposRegistro TipoRegistro { get; set; }
}
