using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class Paise
{
    public int Idpais { get; set; }

    public string Nombre { get; set; }

    public bool Ue { get; set; }

    public bool ExentoIva { get; set; }

    public int Iso31611Num3 { get; set; }

    public string Iso31611Alfa3 { get; set; }

    public string Iso31611Alfa2 { get; set; }

    public string PrefijoTel { get; set; }

    public string NombrePostal { get; set; }

    public bool? Activo { get; set; }

    public virtual ICollection<ClientesDireccione> ClientesDirecciones { get; set; } = new List<ClientesDireccione>();

    public virtual ICollection<Comarca> Comarcas { get; set; } = new List<Comarca>();

    public virtual ICollection<EmpleadosDireccione> EmpleadosDirecciones { get; set; } = new List<EmpleadosDireccione>();

    public virtual ICollection<Provincia> Provincia { get; set; } = new List<Provincia>();
}
