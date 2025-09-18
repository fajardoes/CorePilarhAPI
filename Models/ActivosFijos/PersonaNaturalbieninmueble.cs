using System;
using System.Collections.Generic;

namespace GestionesPilarh.Models.ActivosFijos;

public partial class PersonaNaturalbieninmueble
{
    public int Secuencial { get; set; }

    public int Secuencialpersonanatural { get; set; }

    public string Clase { get; set; } = null!;

    public string Direccion { get; set; } = null!;

    public decimal Avaluocomercial { get; set; }

    public string? Hipotecadoa { get; set; }

    public string Numeroescritura { get; set; } = null!;

    public int Numeronotaria { get; set; }

    public string Ciudadnotaria { get; set; } = null!;

    public bool Estaactivo { get; set; }

    public int Numeroverificador { get; set; }

    public int? Secuencialubicaciongeografica { get; set; }

    public virtual PersonaNaturalbieninmuebleDireccionformateadum? PersonaNaturalbieninmuebleDireccionformateadum { get; set; }

    public virtual PersonaNatural SecuencialpersonanaturalNavigation { get; set; } = null!;
}
