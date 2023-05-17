using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class DgDireccione
{
    public int Iddgdireccion { get; set; }

    public string Nombre { get; set; }

    public string Direccion { get; set; }

    public int LocalidadId { get; set; }

    public int? ProvinciaId { get; set; }

    public int? PaisId { get; set; }

    public string CodigoPostal { get; set; }
}
