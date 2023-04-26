using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class EmpleadosDireccione
{
    public int IdempleadoDireccion { get; set; }

    public int EmpleadoId { get; set; }

    public int LocalidadId { get; set; }

    public int ProvinciaId { get; set; }

    public int? PaisId { get; set; }

    public string Direccion { get; set; }

    public string CodigoPostal { get; set; }

    public string Descripcion { get; set; }

    public virtual Empleado Empleado { get; set; }

    public virtual Localidade Localidad { get; set; }

    public virtual Paise Pais { get; set; }

    public virtual Provincia Provincia { get; set; }
}
