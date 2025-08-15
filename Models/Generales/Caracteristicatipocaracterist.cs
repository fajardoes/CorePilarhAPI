using System;
using System.Collections.Generic;

namespace CorePilarh.Models.Generales;

public partial class Caracteristicatipocaracterist
{
    public int Secuencial { get; set; }

    public string Codigocaracteristica { get; set; } = null!;

    public string Codigotipocaracteristica { get; set; } = null!;

    public bool Estaactivo { get; set; }

    public int Numeroverificador { get; set; }

    public virtual Caracteristica CodigocaracteristicaNavigation { get; set; } = null!;

    public virtual Tipocaracteristica CodigotipocaracteristicaNavigation { get; set; } = null!;
}
