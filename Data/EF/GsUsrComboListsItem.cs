using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class GsUsrComboListsItem
{
    public int IdcomboListItem { get; set; }

    public int ComboListId { get; set; }

    public int ItemIndex { get; set; }

    public string ItemValue { get; set; }

    public virtual GsUsrComboList ComboList { get; set; }
}
