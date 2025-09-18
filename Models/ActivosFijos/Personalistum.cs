using System;
using System.Collections.Generic;

namespace GestionesPilarh.Models.ActivosFijos;

public partial class Personalistum
{
    public int Secuencial { get; set; }

    public int Secuencialpersona { get; set; }

    public int Secuencialcaracteristicalista { get; set; }

    public bool Estaactivo { get; set; }

    public int Numeroverificador { get; set; }

    public virtual Persona SecuencialpersonaNavigation { get; set; } = null!;
}
