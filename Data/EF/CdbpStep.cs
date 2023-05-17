using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class CdbpStep
{
    public int Idstep { get; set; }

    public int ProcessId { get; set; }

    public Guid IdguidConnection { get; set; }

    public string Descripcion { get; set; }

    public int Orden { get; set; }

    public string MethodName { get; set; }

    /// <summary>
    /// 1 &gt; StoredProc; 2 &gt; Llamada a código compilado (se comprueba LibraryName)
    /// </summary>
    public int MethodTypeId { get; set; }

    public string LibraryName { get; set; }

    public virtual CdbpProcess Process { get; set; }
}
