using System;
using System.Collections.Generic;

namespace GestionesPilarh.Models.Generales;

public partial class DivisionEnlazaactiecon
{
    public int Secuencial { get; set; }

    public int Secuencialdivisionactiecon { get; set; }

    public int Secuencialdivisionactieconcnbs { get; set; }

    public bool Estaactivo { get; set; }

    public int Numeroverificador { get; set; }

    public virtual Division SecuencialdivisionactieconNavigation { get; set; } = null!;

    public virtual Division SecuencialdivisionactieconcnbsNavigation { get; set; } = null!;
}
