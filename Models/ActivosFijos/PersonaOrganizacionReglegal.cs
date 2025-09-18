using System;
using System.Collections.Generic;

namespace GestionesPilarh.Models.ActivosFijos;

public partial class PersonaOrganizacionReglegal
{
    public int Secuencialpersonaorganizacion { get; set; }

    public DateTime Fechacreacionlegal { get; set; }

    public string Registrolegal { get; set; } = null!;

    public int Numeroverificador { get; set; }

    public virtual PersonaOrganizacion SecuencialpersonaorganizacionNavigation { get; set; } = null!;
}
