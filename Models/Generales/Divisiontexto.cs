using System;
using System.Collections.Generic;

namespace CorePilarh.Models.Generales;

public partial class Divisiontexto
{
    public int Secuencial { get; set; }

    public int Secuencialdivision { get; set; }

    public string Codigocaracteristica { get; set; } = null!;

    public string Valor { get; set; } = null!;

    public bool Estaactivo { get; set; }

    public int Numeroverificador { get; set; }

    public virtual Caracteristica CodigocaracteristicaNavigation { get; set; } = null!;

    public virtual Division SecuencialdivisionNavigation { get; set; } = null!;
}
