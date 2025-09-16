using System;
using System.Collections.Generic;

namespace GestionesPilarh.Models.Generales;

public partial class Divisionbooleana
{
    public int Secuencial { get; set; }

    public int Secuencialdivision { get; set; }

    public string Codigocaracteristica { get; set; } = null!;

    public bool Valor { get; set; }

    public bool Estaactivo { get; set; }

    public int Numeroverificador { get; set; }

    public virtual Caracteristica CodigocaracteristicaNavigation { get; set; } = null!;

    public virtual Division SecuencialdivisionNavigation { get; set; } = null!;
}
