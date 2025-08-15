using System;
using System.Collections.Generic;

namespace CorePilarh.Models.Generales;

public partial class Divisioncaracteristicalistum
{
    public int Secuencial { get; set; }

    public int Secuencialdivision { get; set; }

    public int Secuencialcaracteristicalista { get; set; }

    public bool Estaactivo { get; set; }

    public int Numeroverificador { get; set; }

    public virtual Caracteristicalistum SecuencialcaracteristicalistaNavigation { get; set; } = null!;

    public virtual Division SecuencialdivisionNavigation { get; set; } = null!;
}
