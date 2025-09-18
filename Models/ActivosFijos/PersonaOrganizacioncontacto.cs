using System;
using System.Collections.Generic;

namespace GestionesPilarh.Models.ActivosFijos;

public partial class PersonaOrganizacioncontacto
{
    public int Secuencial { get; set; }

    public int Secuencialpersonaorganizacion { get; set; }

    public int Orden { get; set; }

    public string Profesion { get; set; } = null!;

    public string Nombresyapellidos { get; set; } = null!;

    public string Cargo { get; set; } = null!;

    public string Numerotelefono { get; set; } = null!;

    public string Extension { get; set; } = null!;

    public string Celular { get; set; } = null!;

    public bool Estaactivo { get; set; }

    public int Numeroverificador { get; set; }

    public virtual PersonaOrganizacion SecuencialpersonaorganizacionNavigation { get; set; } = null!;
}
