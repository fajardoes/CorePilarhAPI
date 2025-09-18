using System;
using System.Collections.Generic;

namespace GestionesPilarh.Models.ActivosFijos;

public partial class PersonaDireccionformateadum
{
    public int Secuencialpersona { get; set; }

    public string Direcciondomicilioformateada { get; set; } = null!;

    public string Calleprincipal { get; set; } = null!;

    public string Numerocasa { get; set; } = null!;

    public string Callesecundaria { get; set; } = null!;

    public virtual Persona SecuencialpersonaNavigation { get; set; } = null!;
}
