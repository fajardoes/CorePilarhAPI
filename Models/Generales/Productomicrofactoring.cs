using System;
using System.Collections.Generic;

namespace CorePilarh.Models.Generales;

public partial class Productomicrofactoring
{
    public int Secuencial { get; set; }

    public string Nombre { get; set; } = null!;

    public bool Estaactivo { get; set; }

    public int Numeroverificador { get; set; }
}
