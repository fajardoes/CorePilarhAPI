using System;
using System.Collections.Generic;

namespace GestionesPilarh.Models.ActivosFijos;

public partial class TipoidentificacionCambio
{
    public int Secuencial { get; set; }

    public int? Secuencialtipoidorigen { get; set; }

    public int? Secuencialtipoiddestino { get; set; }

    public bool? Estaactiva { get; set; }

    public int? Numeroverificador { get; set; }

    public virtual Tipoidentificacion? SecuencialtipoiddestinoNavigation { get; set; }

    public virtual Tipoidentificacion? SecuencialtipoidorigenNavigation { get; set; }
}
