using System;
using System.Collections.Generic;

namespace GestionesPilarh.Models.ActivosFijos;

public partial class PersonaNaturalocupacion
{
    public int Secuencial { get; set; }

    public int Secuencialpersonanatural { get; set; }

    public string Descripcionocupacion { get; set; } = null!;

    public string Direccion { get; set; } = null!;

    public decimal Ingresomensualocupacion { get; set; }

    public DateTime Fechainicio { get; set; }

    public int Secuencialdivpolubicacion { get; set; }

    public int Secuencialdivactividadecon { get; set; }

    public bool Esprincipal { get; set; }

    public string Lugartrabajo { get; set; } = null!;

    public string Cargo { get; set; } = null!;

    public string Referenciaubicacion { get; set; } = null!;

    public string Codigotipoocupacion { get; set; } = null!;

    public int Tiemposervicio { get; set; }

    public int Tiempoexperiencia { get; set; }

    public string Codigotipolocal { get; set; } = null!;

    public decimal Valorarriendonegocio { get; set; }

    public decimal Valoranticresisnegocio { get; set; }

    public string? Telefonofijo { get; set; }

    public string? Telefonocelular { get; set; }

    public bool Esnegocio { get; set; }

    public bool Estaactiva { get; set; }

    public int Numeroverificador { get; set; }

    public decimal? Sueldobase { get; set; }

    public virtual Tipolocal CodigotipolocalNavigation { get; set; } = null!;

    public virtual Tipoocupacion CodigotipoocupacionNavigation { get; set; } = null!;

    public virtual PerNatocupaciondireccion? PerNatocupaciondireccion { get; set; }

    public virtual PersonaNaturalocupacionorg? PersonaNaturalocupacionorg { get; set; }

    public virtual PersonaNatural SecuencialpersonanaturalNavigation { get; set; } = null!;
}
