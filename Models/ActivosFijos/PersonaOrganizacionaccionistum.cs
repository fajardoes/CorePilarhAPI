using System;
using System.Collections.Generic;

namespace GestionesPilarh.Models.ActivosFijos;

public partial class PersonaOrganizacionaccionistum
{
    public int Secuencial { get; set; }

    public int Secuencialpersonaorganizacion { get; set; }

    public string Identificacion { get; set; } = null!;

    public string Apellidos { get; set; } = null!;

    public string Nombres { get; set; } = null!;

    public string Telefono { get; set; } = null!;

    public bool Estaactivo { get; set; }

    public int Numeroverificador { get; set; }

    public int? Secuencialtipoidentificacion { get; set; }

    public virtual PersonaOrganizacion SecuencialpersonaorganizacionNavigation { get; set; } = null!;

    public virtual Tipoidentificacion? SecuencialtipoidentificacionNavigation { get; set; }
}
