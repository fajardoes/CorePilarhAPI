using System;
using System.Collections.Generic;

namespace GestionesPilarh.Models.ActivosFijos;

public partial class Tipoidentificacionpai
{
    public int Secuencial { get; set; }

    public int Secuencialtipoidentificacion { get; set; }

    public string Codigopais { get; set; } = null!;

    public bool Estaactiva { get; set; }

    public int Numeroverificador { get; set; }

    public virtual Tipoidentificacion SecuencialtipoidentificacionNavigation { get; set; } = null!;
}
