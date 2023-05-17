using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class Comarca
{
    public int Idcomarca { get; set; }

    public int? PaisId { get; set; }

    public string Nombre { get; set; }

    public virtual ICollection<Localidade> Localidades { get; set; } = new List<Localidade>();

    public virtual Paise Pais { get; set; }
}
