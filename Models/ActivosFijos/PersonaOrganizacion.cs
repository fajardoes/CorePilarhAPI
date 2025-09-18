using System;
using System.Collections.Generic;

namespace GestionesPilarh.Models.ActivosFijos;

public partial class PersonaOrganizacion
{
    public int Secuencialpersona { get; set; }

    public string Razonsocial { get; set; } = null!;

    public string? Objetosocial { get; set; }

    public DateTime Fechacreacion { get; set; }

    public decimal Activostotales { get; set; }

    public decimal Pasivostotales { get; set; }

    public decimal Ingresosmensuales { get; set; }

    public decimal Egresosmensuales { get; set; }

    public virtual ICollection<PersonaNaturalocupacionorg> PersonaNaturalocupacionorgs { get; set; } = new List<PersonaNaturalocupacionorg>();

    public virtual PersonaOrganizacionCompl? PersonaOrganizacionCompl { get; set; }

    public virtual PersonaOrganizacionGrupo? PersonaOrganizacionGrupo { get; set; }

    public virtual PersonaOrganizacionReglegal? PersonaOrganizacionReglegal { get; set; }

    public virtual ICollection<PersonaOrganizacionaccionistum> PersonaOrganizacionaccionista { get; set; } = new List<PersonaOrganizacionaccionistum>();

    public virtual ICollection<PersonaOrganizacioncontacto> PersonaOrganizacioncontactos { get; set; } = new List<PersonaOrganizacioncontacto>();

    public virtual ICollection<PersonaOrganizacionocupacion> PersonaOrganizacionocupacions { get; set; } = new List<PersonaOrganizacionocupacion>();

    public virtual Persona SecuencialpersonaNavigation { get; set; } = null!;
}
