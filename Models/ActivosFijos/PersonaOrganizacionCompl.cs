using System;
using System.Collections.Generic;

namespace GestionesPilarh.Models.ActivosFijos;

public partial class PersonaOrganizacionCompl
{
    public int Secuencialpersonaorganizacion { get; set; }

    public bool Essujetoir { get; set; }

    public bool Esinstitucionfinanciera { get; set; }

    public int Numeroverificador { get; set; }

    public virtual PersonaOrganizacion SecuencialpersonaorganizacionNavigation { get; set; } = null!;
}
