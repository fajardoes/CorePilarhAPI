using System;
using System.Collections.Generic;

namespace GestionesPilarh.Models.ActivosFijos;

public partial class Personatexto
{
    public int Secuencial { get; set; }

    public int Secuencialpersona { get; set; }

    public string Codigocaracteristica { get; set; } = null!;

    public string Valor { get; set; } = null!;

    public bool Estaactivo { get; set; }

    public int Numeroverificador { get; set; }

    public virtual Persona SecuencialpersonaNavigation { get; set; } = null!;
}
