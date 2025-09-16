using System;
using System.Collections.Generic;

namespace GestionesPilarh.Models.Generales;
public partial class Institucionfinanciera
{
    public int Secuencial { get; set; }

    public string Abreviatura { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public bool Esregulada { get; set; }

    public bool Estaactiva { get; set; }

    public int Numeroverificador { get; set; }
}
