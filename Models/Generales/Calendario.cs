using System;
using System.Collections.Generic;

namespace GestionesPilarh.Models.Generales;

public partial class Calendario
{
    public int Secuencial { get; set; }

    public int Secuencialempresa { get; set; }

    public DateTime Fechasistema { get; set; }

    public bool Estacerrado { get; set; }

    public bool Esferiado { get; set; }

    public int Numeroverificador { get; set; }

    public bool? Eshabil { get; set; }

    public bool Esdepago { get; set; }

    public virtual Empresa SecuencialempresaNavigation { get; set; } = null!;
}
