using System;
using System.Collections.Generic;

namespace GestionesPilarh.Models.ActivosFijos;

public partial class PersonaOrganizacionGrreunion
{
    public int Secuencial { get; set; }

    public int Secuencialpersonaorggrupo { get; set; }

    public string Codigotiporeunion { get; set; } = null!;

    public DateTime Fecha { get; set; }

    public string Hora { get; set; } = null!;

    public string Codigousuarioregistra { get; set; } = null!;

    public bool Vistobueno { get; set; }

    public string Comentario { get; set; } = null!;

    public bool Estaactivo { get; set; }

    public int Numeroverificador { get; set; }

    public virtual Tiporeuniongrupo CodigotiporeunionNavigation { get; set; } = null!;

    public virtual PersonaOrganizacionGrupo SecuencialpersonaorggrupoNavigation { get; set; } = null!;
}
