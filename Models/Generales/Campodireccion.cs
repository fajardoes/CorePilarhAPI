using System;
using System.Collections.Generic;

namespace GestionesPilarh.Models.Generales;

public partial class Campodireccion
{
    public string Codigo { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public bool Masusado { get; set; }

    public bool Posiblenombre { get; set; }

    public bool Estaactivo { get; set; }

    public int Numeroverificador { get; set; }
}
