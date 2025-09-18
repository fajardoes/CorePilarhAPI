using System;
using System.Collections.Generic;

namespace GestionesPilarh.Models.ActivosFijos;

public partial class Tipodocumentoadicional
{
    public int Secuencial { get; set; }

    public string Codigo { get; set; } = null!;

    public string Siglas { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public bool Parapersonanatural { get; set; }

    public bool Parapersonajuridica { get; set; }

    public int Numerominimorepresentantes { get; set; }

    public int Numerominimoreferenciaspersona { get; set; }

    public int Numerominimoreferenciasbancari { get; set; }

    public int Numerominimoreferenciascomerci { get; set; }

    public bool Estaactiva { get; set; }

    public int Numeroverificador { get; set; }

    public virtual TipodocumentoadicionalAutomatica? TipodocumentoadicionalAutomatica { get; set; }

    public virtual TipodocumentoadicionalFormato? TipodocumentoadicionalFormato { get; set; }

    public virtual TipodocumentoadicionalMetodo? TipodocumentoadicionalMetodo { get; set; }
}
