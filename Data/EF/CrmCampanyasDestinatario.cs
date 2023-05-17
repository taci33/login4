using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class CrmCampanyasDestinatario
{
    public int Iddestinatario { get; set; }

    public int CabeceraId { get; set; }

    public int PersonaId { get; set; }

    public int? ContactoId { get; set; }

    public virtual CrmCampanya Cabecera { get; set; }

    public virtual ClientesContacto Contacto { get; set; }

    public virtual ICollection<CrmCampanyasSeguimiento> CrmCampanyasSeguimientos { get; set; } = new List<CrmCampanyasSeguimiento>();

    public virtual Cliente Persona { get; set; }
}
