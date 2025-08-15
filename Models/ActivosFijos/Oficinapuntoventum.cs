using System;
using System.Collections.Generic;

namespace CorePilarh.Models.ActivosFijos;

public partial class Oficinapuntoventum
{
    public int Secuencial { get; set; }

    public int Secuencialoficina { get; set; }

    public string Nombre { get; set; } = null!;

    public bool Estaactivo { get; set; }

    public int Numeroverificador { get; set; }

    public virtual PuntodeventaDepartamento? PuntodeventaDepartamento { get; set; }

    public virtual Oficina SecuencialoficinaNavigation { get; set; } = null!;
}
