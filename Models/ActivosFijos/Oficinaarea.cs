using System;
using System.Collections.Generic;

namespace GestionesPilarh.Models.ActivosFijos;

public partial class Oficinaarea
{
    public int Secuencial { get; set; }

    public int Secuencialoficina { get; set; }

    public int Secuencialarea { get; set; }

    public bool Estaactiva { get; set; }

    public int Numeroverificador { get; set; }

    public virtual Area SecuencialareaNavigation { get; set; } = null!;

    public virtual Oficina SecuencialoficinaNavigation { get; set; } = null!;
}
