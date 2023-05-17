using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class RemesasCompra
{
    public int Idremesa { get; set; }

    public int Numero { get; set; }

    public int Anno { get; set; }

    public int CuentaId { get; set; }

    public DateTime FechaCargo { get; set; }

    public string Comentario { get; set; }

    public int Tipo { get; set; }

    public bool Contabilizada { get; set; }

    public int? EjercicioId { get; set; }

    public DateTime? FechaFirma { get; set; }

    public virtual EmpresasCuentasBancaria Cuenta { get; set; }

    public virtual Ejercicio Ejercicio { get; set; }

    public virtual ICollection<VencimientosCompra> VencimientosCompras { get; set; } = new List<VencimientosCompra>();
}
