using System;
using System.Collections.Generic;

namespace GestionesPilarh.Models.ActivosFijos;

public partial class Tipoidentificacion
{
    public int Secuencial { get; set; }

    public string Codigo { get; set; } = null!;

    public string Siglas { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public bool Parapersonanatural { get; set; }

    public bool? Parapersonajuridica { get; set; }

    public int Numerominimorepresentantes { get; set; }

    public int Numerominimoreferenciaspersona { get; set; }

    public int Numerominimoreferenciasbancari { get; set; }

    public int Numerominimoreferenciascomerci { get; set; }

    public bool Estaactiva { get; set; }

    public int Numeroverificador { get; set; }

    public virtual ICollection<PersonaOrganizacionaccionistum> PersonaOrganizacionaccionista { get; set; } = new List<PersonaOrganizacionaccionistum>();

    public virtual ICollection<Personadocumentoadicionalr> Personadocumentoadicionalrs { get; set; } = new List<Personadocumentoadicionalr>();

    public virtual ICollection<Persona> Personas { get; set; } = new List<Persona>();

    public virtual TipoidentificacionAutomatica? TipoidentificacionAutomatica { get; set; }

    public virtual ICollection<TipoidentificacionCambio> TipoidentificacionCambioSecuencialtipoiddestinoNavigations { get; set; } = new List<TipoidentificacionCambio>();

    public virtual ICollection<TipoidentificacionCambio> TipoidentificacionCambioSecuencialtipoidorigenNavigations { get; set; } = new List<TipoidentificacionCambio>();

    public virtual TipoidentificacionCodcrerep? TipoidentificacionCodcrerep { get; set; }

    public virtual TipoidentificacionFormato? TipoidentificacionFormato { get; set; }

    public virtual TipoidentificacionMetodo? TipoidentificacionMetodo { get; set; }

    public virtual TipoidentificacionRdep? TipoidentificacionRdep { get; set; }

    public virtual ICollection<Tipoidentificacionpai> Tipoidentificacionpais { get; set; } = new List<Tipoidentificacionpai>();

    public virtual ICollection<Tipoidentificacionrangoedad> Tipoidentificacionrangoedads { get; set; } = new List<Tipoidentificacionrangoedad>();
}
