using System;
using System.Collections.Generic;

namespace CorePilarh.Models.ActivosFijos;

public partial class OficinaFirmante
{
    public int Secuencialoficina { get; set; }

    public string Codigousuariofirmacarta { get; set; } = null!;

    public virtual Oficina SecuencialoficinaNavigation { get; set; } = null!;
}
