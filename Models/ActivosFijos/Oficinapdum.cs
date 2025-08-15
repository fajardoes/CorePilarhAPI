using System;
using System.Collections.Generic;

namespace CorePilarh.Models.ActivosFijos;

public partial class Oficinapdum
{
    public int Secuencial { get; set; }

    public int Secuencialoficina { get; set; }

    public int Secuencialpda { get; set; }

    public bool Estaactivo { get; set; }

    public int Numeroverificador { get; set; }

    public virtual Oficina SecuencialoficinaNavigation { get; set; } = null!;

    public virtual Pdum SecuencialpdaNavigation { get; set; } = null!;
}
