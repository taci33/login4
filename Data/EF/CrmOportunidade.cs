using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class CrmOportunidade
{
    public int Idoportunidad { get; set; }

    public int EstadoId { get; set; }

    public int? PersonaId { get; set; }

    public string Asunto { get; set; }

    public string Descripcion { get; set; }

    public int PrioridadId { get; set; }

    public virtual CrmOportunidadesEstado Estado { get; set; }

    public virtual Cliente Persona { get; set; }

    public virtual CrmOportunidadesPrioridade Prioridad { get; set; }
}
