using System;
using System.Collections.Generic;

namespace GestionesPilarh.Models.Generales;

public partial class CaracteristicaTexto
{
    public string Codigocaracteristica { get; set; } = null!;

    public int Numerocaracteres { get; set; }

    public bool Estaactivo { get; set; }

    public string Regularexpression { get; set; } = null!;

    public int Numeroverificador { get; set; }

    public bool? Mayusculas { get; set; }

    public virtual Caracteristica CodigocaracteristicaNavigation { get; set; } = null!;
}
