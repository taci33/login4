using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class CdboParametrosAnalitico
{
    public int Idparametro { get; set; }

    public string Nombre { get; set; }

    public bool Obligatorio { get; set; }

    public int UsrTypeId { get; set; }

    public int? ComboListId { get; set; }

    public virtual GsUsrType UsrType { get; set; }
}
