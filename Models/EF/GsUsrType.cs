using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class GsUsrType
{
    public int IdusrType { get; set; }

    public string Nombre { get; set; }

    public int Length { get; set; }

    public string EditMask { get; set; }

    public int? EditMaskTypeId { get; set; }

    public int InternalTypeId { get; set; }

    public int DevExpIndexEditor { get; set; }

    public virtual ICollection<CdboParametrosAnalitico> CdboParametrosAnaliticos { get; set; } = new List<CdboParametrosAnalitico>();

    public virtual ICollection<CrmSegmento> CrmSegmentos { get; set; } = new List<CrmSegmento>();

    public virtual ICollection<DatosDinamico> DatosDinamicos { get; set; } = new List<DatosDinamico>();

    public virtual ICollection<DmnDataSetParameter> DmnDataSetParameters { get; set; } = new List<DmnDataSetParameter>();

    public virtual GsEditMasksType EditMaskType { get; set; }

    public virtual ICollection<GsUsrComboList> GsUsrComboListItemsUsrTypes { get; set; } = new List<GsUsrComboList>();

    public virtual ICollection<GsUsrComboList> GsUsrComboListUsrTypes { get; set; } = new List<GsUsrComboList>();

    public virtual GsInternalType InternalType { get; set; }

    public virtual ICollection<LabDatosDinamico> LabDatosDinamicos { get; set; } = new List<LabDatosDinamico>();
}
