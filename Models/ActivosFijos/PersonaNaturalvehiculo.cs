using System;
using System.Collections.Generic;

namespace GestionesPilarh.Models.ActivosFijos;

public partial class PersonaNaturalvehiculo
{
    public int Secuencial { get; set; }

    public int Secuencialpersonanatural { get; set; }

    public string Clase { get; set; } = null!;

    public string Marca { get; set; } = null!;

    public string Modelo { get; set; } = null!;

    public string Placa { get; set; } = null!;

    public decimal Valorcomercial { get; set; }

    public string Pignoradoa { get; set; } = null!;

    public bool Estaactivo { get; set; }

    public int Numeroverificador { get; set; }

    public virtual PersonaNatural SecuencialpersonanaturalNavigation { get; set; } = null!;
}
