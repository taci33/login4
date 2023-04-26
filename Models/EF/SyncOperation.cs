using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class SyncOperation
{
    public int Idoperation { get; set; }

    public bool SynchronizedVisibility { get; set; }

    public string Nombre { get; set; }
}
