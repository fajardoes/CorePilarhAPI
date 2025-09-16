using System;
using System.Collections.Generic;

namespace GestionesPilarh.Models.ActivosFijos;

public partial class ActivoArea
{
    public int Secuencialactivo { get; set; }

    public int Secuencialarea { get; set; }

    public bool Estaactivo { get; set; }

    public int Numeroverificador { get; set; }

    public virtual Activo SecuencialactivoNavigation { get; set; } = null!;

    public virtual Area SecuencialareaNavigation { get; set; } = null!;
}
