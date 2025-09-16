using System;
using System.Collections.Generic;

namespace GestionesPilarh.Models.Generales;

public partial class CampoparametroTexto
{
    public int Secuencialcampoparametro { get; set; }

    public string Codigotipodato { get; set; } = null!;

    public int Maximalongitud { get; set; }

    public bool Estaactivo { get; set; }

    public int Numeroverificador { get; set; }

    public virtual Campoparametro SecuencialcampoparametroNavigation { get; set; } = null!;
}
