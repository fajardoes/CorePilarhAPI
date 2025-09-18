using System;
using System.Collections.Generic;

namespace GestionesPilarh.Models.ActivosFijos;

public partial class Representantehistoricodetalle
{
    public int Secuencial { get; set; }

    public int Secrepresentantehistorico { get; set; }

    public int Secuencialpersonanaturalrepr { get; set; }

    public bool Esprincipal { get; set; }

    public string Nombretiporepresentante { get; set; } = null!;

    public bool Estaactivo { get; set; }

    public virtual Representantehistorico SecrepresentantehistoricoNavigation { get; set; } = null!;
}
