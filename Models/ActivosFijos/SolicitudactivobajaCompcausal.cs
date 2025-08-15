using System;
using System.Collections.Generic;

namespace CorePilarh.Models.ActivosFijos;

public partial class SolicitudactivobajaCompcausal
{
    public int Secuencialactivobaja { get; set; }

    public int Secuencialcomponentecausal { get; set; }

    public virtual Solicitudactivobaja SecuencialactivobajaNavigation { get; set; } = null!;
}
