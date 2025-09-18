using System;
using System.Collections.Generic;

namespace GestionesPilarh.Models.ActivosFijos;

public partial class Referenciabancarium
{
    public int Secuencial { get; set; }

    public int Secuencialpersona { get; set; }

    public int Secuencialbanco { get; set; }

    public string Codigotipocuentareferencia { get; set; } = null!;

    public string Numerocuenta { get; set; } = null!;

    public bool Estaactiva { get; set; }

    public int Numeroverificador { get; set; }

    public virtual Tipocuentareferenciabancarium CodigotipocuentareferenciaNavigation { get; set; } = null!;

    public virtual Persona SecuencialpersonaNavigation { get; set; } = null!;
}
