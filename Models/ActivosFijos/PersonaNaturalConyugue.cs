using System;
using System.Collections.Generic;

namespace GestionesPilarh.Models.ActivosFijos;

public partial class PersonaNaturalConyugue
{
    public int Secuencialpersonanatural { get; set; }

    public string Nombreconyugue { get; set; } = null!;

    public string? Telefono { get; set; }

    public bool Estaactiva { get; set; }

    public int Numeroverificador { get; set; }

    public virtual PersonaNatural SecuencialpersonanaturalNavigation { get; set; } = null!;
}
