using System;
using System.Collections.Generic;

namespace GestionesPilarh.Models.ActivosFijos;

public partial class Referencium
{
    public int Secuencial { get; set; }

    public int Secuencialpersona { get; set; }

    public string Nombres { get; set; } = null!;

    public string Apellidos { get; set; } = null!;

    public string Direccion { get; set; } = null!;

    public string Telefono { get; set; } = null!;

    public string Telefonocelular { get; set; } = null!;

    public string Actividad { get; set; } = null!;

    public string Direccionactividad { get; set; } = null!;

    public string Telefonoactividad { get; set; } = null!;

    public string Telefonocelularactividad { get; set; } = null!;

    public bool Espersonal { get; set; }

    public string Parentesco { get; set; } = null!;

    public bool Estaactiva { get; set; }

    public int Numeroverificador { get; set; }

    public virtual Persona SecuencialpersonaNavigation { get; set; } = null!;
}
