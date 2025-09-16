using System;
using System.Collections.Generic;

namespace GestionesPilarh.Models.Generales;

public partial class Plantillahtml
{
    public int Secuencial { get; set; }

    public string Plantilla { get; set; } = null!;

    public bool Estaactivo { get; set; }

    public int Numeroverificador { get; set; }
}
