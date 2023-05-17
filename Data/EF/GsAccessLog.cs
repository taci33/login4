using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class GsAccessLog
{
    public long IdaccessLog { get; set; }

    public int AplicacionId { get; set; }

    public string AppVersion { get; set; }

    public DateTime Falta { get; set; }

    public string Usr { get; set; }

    public bool Success { get; set; }

    public string IpAddress { get; set; }

    public string Host { get; set; }
}
