using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class CrmCampanyasSeguimiento
{
    public int Idseguimiento { get; set; }

    public int CabeceraId { get; set; }

    public DateTime Fecha { get; set; }

    public int? DestinatarioId { get; set; }

    public string Respuesta { get; set; }

    public virtual CrmCampanya Cabecera { get; set; }

    public virtual CrmCampanyasDestinatario Destinatario { get; set; }
}
