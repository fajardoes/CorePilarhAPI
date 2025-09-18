using System;
using System.Collections.Generic;

namespace GestionesPilarh.Models.ActivosFijos;

public partial class Tipoidentificacionrangoedad
{
    public int Secuencial { get; set; }

    public int Secuencialtipoidentificacion { get; set; }

    public string Codigorangoedad { get; set; } = null!;

    public bool Estaactiva { get; set; }

    public int Numeroverificador { get; set; }

    public virtual Rangoedad CodigorangoedadNavigation { get; set; } = null!;

    public virtual Tipoidentificacion SecuencialtipoidentificacionNavigation { get; set; } = null!;
}
