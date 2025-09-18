using System;
using System.Collections.Generic;

namespace GestionesPilarh.Models.ActivosFijos;

public partial class TipodocumentoadicionalMetodo
{
    public int Secuencialtipodocumentoadicional { get; set; }

    public string? Nombremetodovalidaid { get; set; }

    public bool? Utilizaservicio { get; set; }

    public bool? Estaactivo { get; set; }

    public int? Numeroverificador { get; set; }

    public virtual Tipodocumentoadicional SecuencialtipodocumentoadicionalNavigation { get; set; } = null!;
}
