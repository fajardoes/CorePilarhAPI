using System;
using System.Collections.Generic;

namespace GestionesPilarh.Models.ActivosFijos;

public partial class Tiporeuniongrupo
{
    public string Codigo { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public bool Estaactivo { get; set; }

    public int Numeroverificador { get; set; }

    public virtual ICollection<PersonaOrganizacionGrreunion> PersonaOrganizacionGrreunions { get; set; } = new List<PersonaOrganizacionGrreunion>();
}
