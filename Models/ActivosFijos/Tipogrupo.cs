using System;
using System.Collections.Generic;

namespace GestionesPilarh.Models.ActivosFijos;

public partial class Tipogrupo
{
    public string Codigo { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public int Numeroderepresentantes { get; set; }

    public int Numerominimodeintegrantes { get; set; }

    public int Numeromaximodeintegrantes { get; set; }

    public bool Aceptaproyectocomun { get; set; }

    public bool Estaactivo { get; set; }

    public int Numeroverificador { get; set; }

    public virtual ICollection<PersonaOrganizacionGrupo> PersonaOrganizacionGrupos { get; set; } = new List<PersonaOrganizacionGrupo>();
}
