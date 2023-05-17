using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class BienesAmortizablesCategoria
{
    public int Idcategoria { get; set; }

    public string Codigo { get; set; }

    public string CuentaAmortizacion { get; set; }

    public string Descripcion { get; set; }

    public int TipoId { get; set; }

    public string CuentaDotacion { get; set; }

    public int Ndepreciaciones { get; set; }

    public int LongitudPeriodo { get; set; }

    public int MetodoDepreciacionId { get; set; }

    public virtual ICollection<BienesAmortizable> BienesAmortizables { get; set; } = new List<BienesAmortizable>();
}
