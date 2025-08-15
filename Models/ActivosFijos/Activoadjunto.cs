using System;
using System.Collections.Generic;

namespace CorePilarh.Models.ActivosFijos;

public partial class Activoadjunto
{
    public int Secuencial { get; set; }

    public int? Secuencialactivo { get; set; }

    public string? Filename { get; set; }

    public string? Contenttype { get; set; }

    public byte[]? Filedata { get; set; }

    public DateTime? Fecharegistro { get; set; }

    public virtual Activo? SecuencialactivoNavigation { get; set; }
}
