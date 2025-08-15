using System;
using System.Collections.Generic;

namespace CorePilarh.Models.ActivosFijos;

public partial class Oficinazona
{
    public int Secuencial { get; set; }

    public int Secuencialoficina { get; set; }

    public int Secuencialzona { get; set; }

    public bool Estaactivo { get; set; }

    public int Numeroverificador { get; set; }

    public virtual Oficina SecuencialoficinaNavigation { get; set; } = null!;

    public virtual Zona SecuencialzonaNavigation { get; set; } = null!;
}
