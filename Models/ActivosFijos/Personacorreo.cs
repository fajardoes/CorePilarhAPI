using System;
using System.Collections.Generic;

namespace GestionesPilarh.Models.ActivosFijos;

public partial class Personacorreo
{
    public int Secuencial { get; set; }

    public int Secuencialpersona { get; set; }

    public string Correoelectronico { get; set; } = null!;

    public string Codigotipocorreo { get; set; } = null!;

    public bool Esenviotoken { get; set; }

    public bool Estaactivo { get; set; }

    public int Numeroverificador { get; set; }

    public virtual Persona SecuencialpersonaNavigation { get; set; } = null!;
}
