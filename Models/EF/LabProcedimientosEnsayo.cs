using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class LabProcedimientosEnsayo
{
    public int Idprocedimiento { get; set; }

    public string Nombre { get; set; }

    public string Descripcion { get; set; }

    public int? Sinac { get; set; }

    public virtual ICollection<LabOasDetalle> LabOasDetalles { get; set; } = new List<LabOasDetalle>();

    public virtual ICollection<PresupuestosVentaDetalleCdbo> PresupuestosVentaDetalleCdbos { get; set; } = new List<PresupuestosVentaDetalleCdbo>();

    public virtual ICollection<ProductosCdbo> ProductosCdbos { get; set; } = new List<ProductosCdbo>();

    public virtual ICollection<ProductosCompuestosCdbo> ProductosCompuestosCdbos { get; set; } = new List<ProductosCompuestosCdbo>();
}
