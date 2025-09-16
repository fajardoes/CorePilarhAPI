using System;
using System.Collections.Generic;

namespace GestionesPilarh.Models.Generales;

public partial class DivisionCodigordep
{
    public int Secuencialdivision { get; set; }

    public string Codigordep { get; set; } = null!;

    public bool Estaactivo { get; set; }

    public int Numeroverificador { get; set; }

    public virtual Division SecuencialdivisionNavigation { get; set; } = null!;
}
