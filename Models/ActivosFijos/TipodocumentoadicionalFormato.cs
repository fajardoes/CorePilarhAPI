using System;
using System.Collections.Generic;

namespace GestionesPilarh.Models.ActivosFijos;

public partial class TipodocumentoadicionalFormato
{
    public int Secuencialtipodocumentoadicional { get; set; }

    public string Formato { get; set; } = null!;

    public bool Estaactivo { get; set; }

    public int Numeroverificador { get; set; }

    public virtual Tipodocumentoadicional SecuencialtipodocumentoadicionalNavigation { get; set; } = null!;
}
