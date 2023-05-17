using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class Tpvimg
{
    public int Idimg { get; set; }

    public byte[] Imagen { get; set; }

    public string Txt { get; set; }
}
