using System;
using System.Collections.Generic;

namespace GestionesPilarh.Models.ActivosFijos;

public partial class TipodocumentoadicionalAutomatica
{
    public int Secuencialtipodocumentoadicional { get; set; }

    public string Precodigo { get; set; } = null!;

    public string Postcodigo { get; set; } = null!;

    public int Ultimosecuencial { get; set; }

    public int Numerocaracteressinprepostcod { get; set; }

    public bool Estaactiva { get; set; }

    public int Numeroverificador { get; set; }

    public virtual Tipodocumentoadicional SecuencialtipodocumentoadicionalNavigation { get; set; } = null!;
}
