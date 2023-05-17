using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class FormulariosCategoria
{
    public int Idcategoria { get; set; }

    public int? CategoriaId { get; set; }

    public string Nombre { get; set; }

    public virtual FormulariosCategoria Categoria { get; set; }

    public virtual ICollection<Formulario> Formularios { get; set; } = new List<Formulario>();

    public virtual ICollection<FormulariosCategoria> InverseCategoria { get; set; } = new List<FormulariosCategoria>();
}
