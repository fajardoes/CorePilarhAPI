using System;
using System.Collections.Generic;

namespace GestionesPilarh.Models.ActivosFijos;

public partial class Calculooficinacalculo
{
    public int Secuencial { get; set; }

    public int Secuencialcalculooficina { get; set; }

    public int Secuencialcalculo { get; set; }

    public virtual Calculo SecuencialcalculoNavigation { get; set; } = null!;

    public virtual Calculooficina SecuencialcalculooficinaNavigation { get; set; } = null!;
}
