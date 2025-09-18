using System;
using System.Collections.Generic;

namespace GestionesPilarh.Models.ActivosFijos;

public partial class PersonaNaturalFallecimiento
{
    public int Secuencialpersona { get; set; }

    public int Secuencialsolicregistactadefun { get; set; }

    public virtual PersonaNatural SecuencialpersonaNavigation { get; set; } = null!;

    public virtual Solicitudregistroactadefuncion SecuencialsolicregistactadefunNavigation { get; set; } = null!;
}
