using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class CdboProductosXYField
{
    public int Idfield { get; set; }

    public string FieldName { get; set; }

    public string Caption { get; set; }

    public string FieldType { get; set; }

    public bool ReadOnly { get; set; }

    public bool Currency { get; set; }

    public string DisplayFormat { get; set; }
}
