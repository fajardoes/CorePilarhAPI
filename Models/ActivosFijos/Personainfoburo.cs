using System;
using System.Collections.Generic;

namespace GestionesPilarh.Models.ActivosFijos;

public partial class Personainfoburo
{
    public int Secuencial { get; set; }

    public int Secuencialpersona { get; set; }

    public string Codigousuario { get; set; } = null!;

    public string Infoburo { get; set; } = null!;

    public DateTime Fechasistema { get; set; }

    public DateTime Fechamaquina { get; set; }

    public int Numeroverificador { get; set; }

    public bool Consultasatisfactoria { get; set; }

    public int? Secuencialempresaburocredito { get; set; }

    public virtual Persona SecuencialpersonaNavigation { get; set; } = null!;
}
