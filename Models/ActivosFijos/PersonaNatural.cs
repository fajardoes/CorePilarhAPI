using System;
using System.Collections.Generic;

namespace GestionesPilarh.Models.ActivosFijos;

public partial class PersonaNatural
{
    public int Secuencialpersona { get; set; }

    public string Apellidos { get; set; } = null!;

    public string Nombres { get; set; } = null!;

    public DateTime Fechanacimiento { get; set; }

    public bool Esmasculino { get; set; }

    public string Codigoestadocivil { get; set; } = null!;

    public string Codigotipoeducacion { get; set; } = null!;

    public string Codigotipovivienda { get; set; } = null!;

    public string Codigoprofesion { get; set; } = null!;

    public decimal Egresosmensuales { get; set; }

    public decimal Patrimonio { get; set; }

    public string Apellidopaterno { get; set; } = null!;

    public string Apellidomaterno { get; set; } = null!;

    public string Primernombre { get; set; } = null!;

    public string Segundonombre { get; set; } = null!;

    public string Lugarnacimiento { get; set; } = null!;

    public int Cargasfamiliares { get; set; }

    public int Numerohijos { get; set; }

    public string Codigoetnia { get; set; } = null!;

    public virtual Estadocivil CodigoestadocivilNavigation { get; set; } = null!;

    public virtual Etnium CodigoetniaNavigation { get; set; } = null!;

    public virtual Profesion CodigoprofesionNavigation { get; set; } = null!;

    public virtual Tipoeducacion CodigotipoeducacionNavigation { get; set; } = null!;

    public virtual Tipoviviendum CodigotipoviviendaNavigation { get; set; } = null!;

    public virtual ICollection<Juntadirectivaintegrante> Juntadirectivaintegrantes { get; set; } = new List<Juntadirectivaintegrante>();

    public virtual PersonaNaturalArrendatario? PersonaNaturalArrendatario { get; set; }

    public virtual PersonaNaturalConyugue? PersonaNaturalConyugue { get; set; }

    public virtual PersonaNaturalFallecimiento? PersonaNaturalFallecimiento { get; set; }

    public virtual PersonaNaturalLugarnacimiento? PersonaNaturalLugarnacimiento { get; set; }

    public virtual PersonaNaturalPersonalizado? PersonaNaturalPersonalizado { get; set; }

    public virtual ICollection<PersonaNaturalbieninmueble> PersonaNaturalbieninmuebles { get; set; } = new List<PersonaNaturalbieninmueble>();

    public virtual ICollection<PersonaNaturalconyuge> PersonaNaturalconyugeSecuencialconyugepersonanatNavigations { get; set; } = new List<PersonaNaturalconyuge>();

    public virtual PersonaNaturalconyuge? PersonaNaturalconyugeSecuencialpersonanaturalNavigation { get; set; }

    public virtual ICollection<PersonaNaturalfamiliar> PersonaNaturalfamiliarSecuencialpersonafamiliarNavigations { get; set; } = new List<PersonaNaturalfamiliar>();

    public virtual ICollection<PersonaNaturalfamiliar> PersonaNaturalfamiliarSecuencialpersonanaturalNavigations { get; set; } = new List<PersonaNaturalfamiliar>();

    public virtual ICollection<PersonaNaturalobligacion> PersonaNaturalobligacions { get; set; } = new List<PersonaNaturalobligacion>();

    public virtual ICollection<PersonaNaturalocupacion> PersonaNaturalocupacions { get; set; } = new List<PersonaNaturalocupacion>();

    public virtual ICollection<PersonaNaturalvehiculo> PersonaNaturalvehiculos { get; set; } = new List<PersonaNaturalvehiculo>();

    public virtual ICollection<Representante> Representantes { get; set; } = new List<Representante>();

    public virtual Persona SecuencialpersonaNavigation { get; set; } = null!;

    public virtual ICollection<Solicitudregistroactadefuncion> Solicitudregistroactadefuncions { get; set; } = new List<Solicitudregistroactadefuncion>();
}
