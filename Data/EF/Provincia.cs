using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class Provincia
{
    public int Idprovincia { get; set; }

    public int? PaisId { get; set; }

    public string Nombre { get; set; }

    public virtual ICollection<ClientesDireccione> ClientesDirecciones { get; set; } = new List<ClientesDireccione>();

    public virtual ICollection<EmpleadosDireccione> EmpleadosDirecciones { get; set; } = new List<EmpleadosDireccione>();

    public virtual ICollection<Localidade> Localidades { get; set; } = new List<Localidade>();

    public virtual Paise Pais { get; set; }

    public virtual ICollection<Zona> Zonas { get; set; } = new List<Zona>();
}
