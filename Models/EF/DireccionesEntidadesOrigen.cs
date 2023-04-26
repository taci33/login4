using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class DireccionesEntidadesOrigen
{
    public int Idorigen { get; set; }

    public int? EntidadId { get; set; }

    public string Nombre { get; set; }

    public string Descripcion { get; set; }

    public virtual ICollection<AlbaranesVentum> AlbaranesVenta { get; set; } = new List<AlbaranesVentum>();

    public virtual ICollection<DevolucionesVentum> DevolucionesVenta { get; set; } = new List<DevolucionesVentum>();

    public virtual GsEntidade Entidad { get; set; }

    public virtual ICollection<ExpedicionesDetalle> ExpedicionesDetalleDirEntregaEntidadOrigens { get; set; } = new List<ExpedicionesDetalle>();

    public virtual ICollection<ExpedicionesDetalle> ExpedicionesDetalleDirSalidaEntidadOrigens { get; set; } = new List<ExpedicionesDetalle>();
}
