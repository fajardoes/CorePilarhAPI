using System;
using System.Collections.Generic;

namespace GestionesPilarh.Models.Generales;
public partial class Empresatelefonica
{
    public string Codigo { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public string Codigopais { get; set; } = null!;

    public bool Estaactiva { get; set; }

    public int Numeroverificador { get; set; }

    public virtual Pai CodigopaisNavigation { get; set; } = null!;
}
