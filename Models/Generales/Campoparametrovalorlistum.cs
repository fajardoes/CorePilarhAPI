using System;
using System.Collections.Generic;

namespace CorePilarh.Models.Generales;

public partial class Campoparametrovalorlistum
{
    public int Secuencial { get; set; }

    public int Secuencialcampoparametro { get; set; }

    public string Nombre { get; set; } = null!;

    public bool Estaactivo { get; set; }

    public int Numeroverificador { get; set; }

    public virtual Campoparametro SecuencialcampoparametroNavigation { get; set; } = null!;
}
