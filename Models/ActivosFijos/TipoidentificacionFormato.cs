using System;
using System.Collections.Generic;

namespace GestionesPilarh.Models.ActivosFijos;

public partial class TipoidentificacionFormato
{
    public int Secuencialtipoidentificacion { get; set; }

    public string Formato { get; set; } = null!;

    public bool Estaactivo { get; set; }

    public int Numeroverificador { get; set; }

    public virtual Tipoidentificacion SecuencialtipoidentificacionNavigation { get; set; } = null!;
}
