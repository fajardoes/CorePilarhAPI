using System;
using System.Collections.Generic;

namespace GestionesPilarh.Models.ActivosFijos;

public partial class PersonaNaturalbieninmuebleDireccionformateadum
{
    public int SecuencialPersonaNaturalbieninmueble { get; set; }

    public string Direcciondomicilioformateada { get; set; } = null!;

    public string Calleprincipal { get; set; } = null!;

    public string Numerocasa { get; set; } = null!;

    public string Callesecundaria { get; set; } = null!;

    public virtual PersonaNaturalbieninmueble SecuencialPersonaNaturalbieninmuebleNavigation { get; set; } = null!;
}
