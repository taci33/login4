using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class ProductosCdbo
{
    /// <summary>
    /// Hace referencia a la tabla de la que cuelga y es igual a la clave IDCDBO de esa tabla
    /// </summary>
    public long Idcdbo { get; set; }

    public int? ParametroId { get; set; }

    public int? MatrizId { get; set; }

    public string Legislacion { get; set; }

    public int? PlazoEntrega { get; set; }

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

    public string AbreviaturaLote { get; set; }

    public int? TiempoCaducidad { get; set; }

    public int IsSemielaborado { get; set; }

    public virtual LabMatrix Matriz { get; set; }

    public virtual LabProcedimientosEnsayo ProcedimientoEnsayoNavigation { get; set; }

    public virtual Producto Producto { get; set; }
}
