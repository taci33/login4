using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class LabMatrix
{
    public int Idmatriz { get; set; }

    public int? MatrizId { get; set; }

    public string Nombre { get; set; }

    public int? FamiliaId { get; set; }

    public virtual ICollection<LabMatrix> InverseMatriz { get; set; } = new List<LabMatrix>();

    public virtual LabMatrix Matriz { get; set; }

    public virtual ICollection<ProductosCdbo> ProductosCdbos { get; set; } = new List<ProductosCdbo>();
}
