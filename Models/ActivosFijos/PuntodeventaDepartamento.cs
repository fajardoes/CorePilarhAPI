using System;
using System.Collections.Generic;

namespace GestionesPilarh.Models.ActivosFijos;

public partial class PuntodeventaDepartamento
{
    public int Secuencialoficinpuntoventa { get; set; }

    public int Secuencialdepartamento { get; set; }

    public bool Estaactivo { get; set; }

    public int Numeroverificador { get; set; }

    public virtual Departamento SecuencialdepartamentoNavigation { get; set; } = null!;

    public virtual Oficinapuntoventum SecuencialoficinpuntoventaNavigation { get; set; } = null!;
}
