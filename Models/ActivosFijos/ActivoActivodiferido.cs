using System;
using System.Collections.Generic;

namespace GestionesPilarh.Models.ActivosFijos;

public partial class ActivoActivodiferido
{
    public int Secuencialactivo { get; set; }

    public int Plazo { get; set; }

    public decimal? Valorasegurado { get; set; }

    public bool Estaactivo { get; set; }

    public int Numeroverificador { get; set; }

    public virtual Activo SecuencialactivoNavigation { get; set; } = null!;
}
