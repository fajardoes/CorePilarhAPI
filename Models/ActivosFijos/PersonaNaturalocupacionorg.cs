using System;
using System.Collections.Generic;

namespace GestionesPilarh.Models.ActivosFijos;

public partial class PersonaNaturalocupacionorg
{
    public int Secuencial { get; set; }

    public int Secuencialpersonanaturalocu { get; set; }

    public int Secuencialpersonaorganizacion { get; set; }

    public int Numeroverificador { get; set; }

    public virtual PersonaNaturalocupacion SecuencialpersonanaturalocuNavigation { get; set; } = null!;

    public virtual PersonaOrganizacion SecuencialpersonaorganizacionNavigation { get; set; } = null!;
}
