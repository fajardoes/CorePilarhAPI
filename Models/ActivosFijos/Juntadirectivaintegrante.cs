using System;
using System.Collections.Generic;

namespace GestionesPilarh.Models.ActivosFijos;

public partial class Juntadirectivaintegrante
{
    public int Secuencial { get; set; }

    public string Codigocargojuntadirectiva { get; set; } = null!;

    public int Secuencialjuntadirectiva { get; set; }

    public int Secuencialpersonanatural { get; set; }

    public bool Estaactivo { get; set; }

    public int Numeroverificador { get; set; }

    public virtual Juntadirectiva SecuencialjuntadirectivaNavigation { get; set; } = null!;

    public virtual PersonaNatural SecuencialpersonanaturalNavigation { get; set; } = null!;
}
