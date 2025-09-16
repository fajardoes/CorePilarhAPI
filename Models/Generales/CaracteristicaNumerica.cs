using System;
using System.Collections.Generic;

namespace GestionesPilarh.Models.Generales;

public partial class CaracteristicaNumerica
{
    public string Codigocaracteristica { get; set; } = null!;

    public int Precisionentero { get; set; }

    public int Precisiondecimal { get; set; }

    public bool Estaactivo { get; set; }

    public int Numeroverificador { get; set; }

    public virtual Caracteristica CodigocaracteristicaNavigation { get; set; } = null!;
}
