using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class ProductosCompuestosCdbo
{
    public long Idcdbo { get; set; }

    public string ProcedimientoEnsayo { get; set; }

    public string TecnicaAnalisis { get; set; }

    public string Unidades { get; set; }

    public string LimiteCuantificacion { get; set; }

    public string LimiteDeteccion { get; set; }

    public string ValorParametrico { get; set; }

    public double TiempoMaximo { get; set; }

    public double TiempoEspera { get; set; }

    public string Acondicionamiento { get; set; }

    public string Envase { get; set; }

    public decimal Incertidumbre { get; set; }

    public string LimiteMaximo { get; set; }

    public bool Acreditado { get; set; }

    public int? ProcedimientoEnsayoId { get; set; }

    public string CodigoSinac { get; set; }

    public virtual ICollection<LabNormativasParametro> LabNormativasParametros { get; set; } = new List<LabNormativasParametro>();

    public virtual LabProcedimientosEnsayo ProcedimientoEnsayoNavigation { get; set; }

    public virtual ProductosCompuesto ProductosCompuesto { get; set; }
}
