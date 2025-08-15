using System;
using System.Collections.Generic;

namespace CorePilarh.Models.Generales;

public partial class Impuestorentum
{
    public int Secuencial { get; set; }

    public int Periodofiscal { get; set; }

    public decimal Fraccionbasica { get; set; }

    public decimal Fraccionexcedente { get; set; }

    public decimal Impuestofraccionbasica { get; set; }

    public decimal Impuestofraccionexcedente { get; set; }

    public bool Estaactivo { get; set; }

    public int Numeroverificador { get; set; }
}
