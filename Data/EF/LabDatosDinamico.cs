using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class LabDatosDinamico
{
    public int IddatoDinamico { get; set; }

    public string Nombre { get; set; }

    public int UsrTypeId { get; set; }

    public int? ComboListId { get; set; }

    public string DefaultValue { get; set; }

    public virtual ICollection<LabDatosDinamicosLineasDef> LabDatosDinamicosLineasDefs { get; set; } = new List<LabDatosDinamicosLineasDef>();

    public virtual GsUsrType UsrType { get; set; }
}
