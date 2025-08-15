using System;
using System.Collections.Generic;

namespace CorePilarh.Models.ActivosFijos;

public partial class Solicitudactivobajalote
{
    public int Secuencial { get; set; }

    public int Secuencialactivobajalote { get; set; }

    public int Secuencialsolicitudactivobaja { get; set; }

    public virtual Activobajalote SecuencialactivobajaloteNavigation { get; set; } = null!;

    public virtual Solicitudactivobaja SecuencialsolicitudactivobajaNavigation { get; set; } = null!;
}
