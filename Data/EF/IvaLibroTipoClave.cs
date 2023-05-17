using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class IvaLibroTipoClave
{
    public int IdtipoClave { get; set; }

    public string TipoClave { get; set; }

    public string Descripcion { get; set; }

    public virtual ICollection<IvaLibroRepercutido> IvaLibroRepercutidos { get; set; } = new List<IvaLibroRepercutido>();

    public virtual ICollection<IvaLibroSoportado> IvaLibroSoportados { get; set; } = new List<IvaLibroSoportado>();
}
