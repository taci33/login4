using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class Listado
{
    public int IdListado { get; set; }

    public string Descripcion { get; set; }

    public string Informe { get; set; }

    public bool? Disponible { get; set; }

    public bool Daa { get; set; }

    public int TagCriteria { get; set; }

    public bool Aeat { get; set; }
}
