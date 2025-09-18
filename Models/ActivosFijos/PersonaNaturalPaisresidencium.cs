using System;
using System.Collections.Generic;

namespace GestionesPilarh.Models.ActivosFijos;

public partial class PersonaNaturalPaisresidencium
{
    public int Secuencialpersonanatural { get; set; }

    public string? Codigopais { get; set; }

    public bool? Estaactivo { get; set; }

    public int? Numeroverificador { get; set; }
}
