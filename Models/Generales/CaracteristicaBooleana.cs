using System;
using System.Collections.Generic;

namespace GestionesPilarh.Models.Generales;

public partial class CaracteristicaBooleana
{
    public string Codigocaracteristica { get; set; } = null!;

    public bool Estaactivo { get; set; }

    public int Numeroverificador { get; set; }

    public virtual Caracteristica CodigocaracteristicaNavigation { get; set; } = null!;
}
