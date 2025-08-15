using System;
using System.Collections.Generic;

namespace CorePilarh.Models.ActivosFijos;

public partial class OficinaComplemento
{
    public int Secuencialoficina { get; set; }

    public int Secuencialdivisionpolitica { get; set; }

    public bool Estaactivo { get; set; }

    public int Numeroverificador { get; set; }

    public string? Codigodepartamento { get; set; }

    public virtual Oficina SecuencialoficinaNavigation { get; set; } = null!;
}
