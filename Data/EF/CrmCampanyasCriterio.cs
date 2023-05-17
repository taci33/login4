using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class CrmCampanyasCriterio
{
    public int Idcriterio { get; set; }

    public int CabeceraId { get; set; }

    public string Clausula { get; set; }

    public int CampoCriterioId { get; set; }

    public int OperadorId { get; set; }

    public string Valor { get; set; }

    public DateTime? Finicio { get; set; }

    public DateTime? Ffin { get; set; }

    public virtual CrmCampanya Cabecera { get; set; }

    public virtual CrmCamposCriterio CampoCriterio { get; set; }
}
