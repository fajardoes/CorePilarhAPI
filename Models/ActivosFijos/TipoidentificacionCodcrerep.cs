using System;
using System.Collections.Generic;

namespace GestionesPilarh.Models.ActivosFijos;

public partial class TipoidentificacionCodcrerep
{
    public int Secuencialtipoidentificacion { get; set; }

    public string Codigocreditreport { get; set; } = null!;

    public virtual Tipoidentificacion SecuencialtipoidentificacionNavigation { get; set; } = null!;
}
