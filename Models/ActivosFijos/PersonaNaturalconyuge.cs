using System;
using System.Collections.Generic;

namespace GestionesPilarh.Models.ActivosFijos;

public partial class PersonaNaturalconyuge
{
    public int Secuencial { get; set; }

    public int Secuencialpersonanatural { get; set; }

    public int Secuencialconyugepersonanat { get; set; }

    public bool Estaactivo { get; set; }

    public int Numeroverificador { get; set; }

    public virtual PersonaNatural SecuencialconyugepersonanatNavigation { get; set; } = null!;

    public virtual PersonaNatural SecuencialpersonanaturalNavigation { get; set; } = null!;
}
