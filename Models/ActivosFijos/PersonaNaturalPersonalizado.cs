using System;
using System.Collections.Generic;

namespace GestionesPilarh.Models.ActivosFijos;

public partial class PersonaNaturalPersonalizado
{
    public int Secuencialpersonanatural { get; set; }

    public int Mesesresidenciaactual { get; set; }

    public decimal Valorarriendoresidencia { get; set; }

    public decimal Valoranticresisresidencia { get; set; }

    public string Nombrearrendadorresidencia { get; set; } = null!;

    public string Telefonoarrendadorresidencia { get; set; } = null!;

    public bool Esempleado { get; set; }

    public bool Esdirectivo { get; set; }

    public int Anniohabitar { get; set; }

    public int Meshabitar { get; set; }

    public virtual PersonaNatural SecuencialpersonanaturalNavigation { get; set; } = null!;
}
