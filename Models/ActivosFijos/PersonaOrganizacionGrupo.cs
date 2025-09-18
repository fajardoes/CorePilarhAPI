using System;
using System.Collections.Generic;

namespace GestionesPilarh.Models.ActivosFijos;

public partial class PersonaOrganizacionGrupo
{
    public int Secuencialpersonaorganizacion { get; set; }

    public string Codigotipogrupo { get; set; } = null!;

    public int Numerointegrantes { get; set; }

    public bool Proyectocomun { get; set; }

    public string Detalleproyecto { get; set; } = null!;

    public string Formaadquieremateriaprima { get; set; } = null!;

    public string Formaventaproductos { get; set; } = null!;

    public bool Estaactivo { get; set; }

    public int Numeroverificador { get; set; }

    public virtual Tipogrupo CodigotipogrupoNavigation { get; set; } = null!;

    public virtual ICollection<PersonaOrganizacionGrreunion> PersonaOrganizacionGrreunions { get; set; } = new List<PersonaOrganizacionGrreunion>();

    public virtual ICollection<PersonaOrganizacionGruintgr> PersonaOrganizacionGruintgrs { get; set; } = new List<PersonaOrganizacionGruintgr>();

    public virtual PersonaOrganizacion SecuencialpersonaorganizacionNavigation { get; set; } = null!;
}
