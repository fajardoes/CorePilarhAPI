using System;
using System.Collections.Generic;

namespace GestionesPilarh.Models.ActivosFijos;

public partial class Personaproveedor
{
    public int Secuencial { get; set; }

    public int Secuencialpersona { get; set; }

    public string Nombre { get; set; } = null!;

    public bool Estaactivo { get; set; }

    public int Numeroverificador { get; set; }

    public virtual Persona SecuencialpersonaNavigation { get; set; } = null!;
}
