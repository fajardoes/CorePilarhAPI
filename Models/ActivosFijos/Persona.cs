using System;
using System.Collections.Generic;

namespace GestionesPilarh.Models.ActivosFijos;

public partial class Persona
{
    public int Secuencial { get; set; }

    public string Identificacion { get; set; } = null!;

    public string Nombreunido { get; set; } = null!;

    public string Direcciondomicilio { get; set; } = null!;

    public string? Ubicacion { get; set; }

    public string Referenciadomiciliaria { get; set; } = null!;

    public string Email { get; set; } = null!;

    public int Secuencialtipoidentificacion { get; set; }

    public string Codigopaisorigen { get; set; } = null!;

    public int Numeroverificador { get; set; }

    public int Secuencialdivisionactividecon { get; set; }

    public virtual ICollection<Controldetalle> Controldetalles { get; set; } = new List<Controldetalle>();

    public virtual Huelladigitalpersona? Huelladigitalpersona { get; set; }

    public virtual PersonaDireccionformateadum? PersonaDireccionformateadum { get; set; }

    public virtual PersonaEstado? PersonaEstado { get; set; }

    public virtual PersonaFechaultimamodicacion? PersonaFechaultimamodicacion { get; set; }

    public virtual PersonaNatural? PersonaNatural { get; set; }

    public virtual PersonaOrganizacion? PersonaOrganizacion { get; set; }

    public virtual ICollection<PersonaOrganizacionGruintgr> PersonaOrganizacionGruintgrs { get; set; } = new List<PersonaOrganizacionGruintgr>();

    public virtual PersonaResponsable? PersonaResponsable { get; set; }

    public virtual ICollection<Personabooleana> Personabooleanas { get; set; } = new List<Personabooleana>();

    public virtual ICollection<Personacorreo> Personacorreos { get; set; } = new List<Personacorreo>();

    public virtual ICollection<Personadocumentoadicionalr> Personadocumentoadicionalrs { get; set; } = new List<Personadocumentoadicionalr>();

    public virtual ICollection<Personafecha> Personafechas { get; set; } = new List<Personafecha>();

    public virtual ICollection<Personainfoburo> Personainfoburos { get; set; } = new List<Personainfoburo>();

    public virtual ICollection<Personalistum> Personalista { get; set; } = new List<Personalistum>();

    public virtual ICollection<Personanumerica> Personanumericas { get; set; } = new List<Personanumerica>();

    public virtual ICollection<Personaproveedor> Personaproveedors { get; set; } = new List<Personaproveedor>();

    public virtual ICollection<Personatexto> Personatextos { get; set; } = new List<Personatexto>();

    public virtual ICollection<Referencium> Referencia { get; set; } = new List<Referencium>();

    public virtual ICollection<Referenciabancarium> Referenciabancaria { get; set; } = new List<Referenciabancarium>();

    public virtual ICollection<Referenciacomercial> Referenciacomercials { get; set; } = new List<Referenciacomercial>();

    public virtual ICollection<Representante> Representantes { get; set; } = new List<Representante>();

    public virtual Tipoidentificacion SecuencialtipoidentificacionNavigation { get; set; } = null!;

    public virtual ICollection<Telefonopersona> Telefonopersonas { get; set; } = new List<Telefonopersona>();
}
