using System;
using System.Collections.Generic;

namespace GestionesPilarh.Models.ActivosFijos;

public partial class TipoidentificacionMetodo
{
    public int Secuencialtipoidentificacion { get; set; }

    public string Nombremetodovalidaid { get; set; } = null!;

    public bool? Utilizaservicio { get; set; }

    public bool Estaactivo { get; set; }

    public int Numeroverificador { get; set; }

    public virtual Tipoidentificacion SecuencialtipoidentificacionNavigation { get; set; } = null!;
}
