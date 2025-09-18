using System;
using System.Collections.Generic;

namespace GestionesPilarh.Models.ActivosFijos;

public partial class Representante
{
    public int Secuencial { get; set; }

    public int Secuencialpersona { get; set; }

    public int Secuencialpersonanaturalrepr { get; set; }

    public bool Esprincipal { get; set; }

    public string Codigotiporepresentante { get; set; } = null!;

    public bool Estaactivo { get; set; }

    public int Numeroverificador { get; set; }

    public virtual Tiporepresentante CodigotiporepresentanteNavigation { get; set; } = null!;

    public virtual Persona SecuencialpersonaNavigation { get; set; } = null!;

    public virtual PersonaNatural SecuencialpersonanaturalreprNavigation { get; set; } = null!;
}
