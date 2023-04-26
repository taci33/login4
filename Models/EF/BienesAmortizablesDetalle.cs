using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class BienesAmortizablesDetalle
{
    public int Iddetalle { get; set; }

    public int CabeceraId { get; set; }

    public int? Numero { get; set; }

    public string Anno { get; set; }

    public DateTime Fecha { get; set; }

    public decimal ValorAmortizacion { get; set; }

    public bool Contabilizada { get; set; }

    public int? Asiento { get; set; }

    public int? EjercicioId { get; set; }

    public virtual Ejercicio Ejercicio { get; set; }
}
