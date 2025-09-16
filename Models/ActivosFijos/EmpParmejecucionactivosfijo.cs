using System;
using System.Collections.Generic;

namespace GestionesPilarh.Models.ActivosFijos;

public partial class EmpParmejecucionactivosfijo
{
    public int Secuencialempresa { get; set; }

    public bool Sedepreciamensualmente { get; set; }

    public int Numeroniveles { get; set; }

    public int Niveldeterminacondiciones { get; set; }

    public int Numeroverificador { get; set; }

    public decimal Porcentajevalorresidual { get; set; }

    public int Diasdepreciacioneventuales { get; set; }

    public bool Reversadepreciaciontotal { get; set; }
}
