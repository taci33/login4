using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class GsUsrComboList
{
    public int IdcomboList { get; set; }

    public string Nombre { get; set; }

    public string TableName { get; set; }

    public int UsrTypeId { get; set; }

    public int ItemsUsrTypeId { get; set; }

    public virtual ICollection<GsUsrComboListsItem> GsUsrComboListsItems { get; set; } = new List<GsUsrComboListsItem>();

    public virtual GsUsrType ItemsUsrType { get; set; }

    public virtual GsUsrType UsrType { get; set; }
}
