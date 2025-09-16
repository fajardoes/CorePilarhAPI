using System;
using System.Collections.Generic;

namespace GestionesPilarh.Models.ActivosFijos;

public partial class Activocaracteristicalistum
{
    public int Secuencial { get; set; }

    public int Secuencialactivo { get; set; }

    public int Secuencialcaracteristicalista { get; set; }

    public bool Estaactivo { get; set; }

    public int Numeroverificador { get; set; }

    public virtual Activo SecuencialactivoNavigation { get; set; } = null!;
}
