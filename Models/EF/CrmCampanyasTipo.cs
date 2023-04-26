using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class CrmCampanyasTipo
{
    public int Idtipo { get; set; }

    public string Nombre { get; set; }

    public virtual ICollection<CrmCampanya> CrmCampanyas { get; set; } = new List<CrmCampanya>();
}
