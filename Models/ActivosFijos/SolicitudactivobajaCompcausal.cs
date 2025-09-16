using System;
using System.Collections.Generic;

namespace GestionesPilarh.Models.ActivosFijos;

public partial class SolicitudactivobajaCompcausal
{
    public int Secuencialactivobaja { get; set; }

    public int Secuencialcomponentecausal { get; set; }

    public virtual Solicitudactivobaja SecuencialactivobajaNavigation { get; set; } = null!;
}
