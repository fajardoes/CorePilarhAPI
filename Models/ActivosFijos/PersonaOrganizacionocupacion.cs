using System;
using System.Collections.Generic;

namespace GestionesPilarh.Models.ActivosFijos;

public partial class PersonaOrganizacionocupacion
{
    public int Secuencial { get; set; }

    public int Secuencialpersonaorganizacion { get; set; }

    public string Descripcionocupacion { get; set; } = null!;

    public string Direccion { get; set; } = null!;

    public decimal Ingresomensualocupacion { get; set; }

    public DateTime Fechainicio { get; set; }

    public int Secuencialdivpolubicacion { get; set; }

    public int Secuencialdivactividadecon { get; set; }

    public bool Esprincipal { get; set; }

    public string Lugartrabajo { get; set; } = null!;

    public string Cargo { get; set; } = null!;

    public bool Estaactiva { get; set; }

    public int Numeroverificador { get; set; }

    public virtual PersonaOrganizacion SecuencialpersonaorganizacionNavigation { get; set; } = null!;
}
