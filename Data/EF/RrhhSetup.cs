using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class RrhhSetup
{
    public int Idsetup { get; set; }

    public int CategoriaId { get; set; }

    public DateTime Finicio { get; set; }

    public DateTime? Ffin { get; set; }

    public decimal Valor { get; set; }

    public virtual RrhhSetupCategoria Categoria { get; set; }
}
