using System;
using System.Collections.Generic;

namespace GestionesPilarh.Models.ActivosFijos;

public partial class PersonaOrganizacionGruintgr
{
    public int Secuencial { get; set; }

    public int Secuencialpersonaorggrupo { get; set; }

    public int Secuencialpersonaintgrgrupo { get; set; }

    public int Tiempovinculaciongrupo { get; set; }

    public bool Estaactiva { get; set; }

    public int Numeroverificador { get; set; }

    public virtual Persona SecuencialpersonaintgrgrupoNavigation { get; set; } = null!;

    public virtual PersonaOrganizacionGrupo SecuencialpersonaorggrupoNavigation { get; set; } = null!;
}
