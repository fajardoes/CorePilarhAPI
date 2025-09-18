using System;
using System.Collections.Generic;

namespace GestionesPilarh.Models.ActivosFijos;

public partial class PersonaNaturalArrendatario
{
    public int Secuencialpersonanatural { get; set; }

    public string Nombrearrendatario { get; set; } = null!;

    public string Direccion { get; set; } = null!;

    public string Referenciadomiciliaria { get; set; } = null!;

    public string Telefonofijo { get; set; } = null!;

    public string Telefonocelular { get; set; } = null!;

    public bool Estaactivo { get; set; }

    public int Numeroverificador { get; set; }

    public virtual PersonaNatural SecuencialpersonanaturalNavigation { get; set; } = null!;
}
