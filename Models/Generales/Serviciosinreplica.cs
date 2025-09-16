using System;
using System.Collections.Generic;

namespace GestionesPilarh.Models.Generales;
public partial class Serviciosinreplica
{
    public int Secuencial { get; set; }

    public string Nombre { get; set; } = null!;

    public bool Estaactivo { get; set; }

    public int Numeroverificador { get; set; }
}
