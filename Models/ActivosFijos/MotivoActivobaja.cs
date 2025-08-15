using System;
using System.Collections.Generic;

namespace CorePilarh.Models.ActivosFijos;

public partial class MotivoActivobaja
{
    public int Secuencial { get; set; }

    public string Descripcion { get; set; } = null!;

    public bool Estaactivo { get; set; }

    public int Numeroverificador { get; set; }

    public bool? Tienecuentabajapropia { get; set; }

    public int? Secuencialcuentacontable { get; set; }

    public virtual ICollection<ActivoBaja> ActivoBajas { get; set; } = new List<ActivoBaja>();

    public virtual ICollection<Activobajalote> Activobajalotes { get; set; } = new List<Activobajalote>();

    public virtual ICollection<Motivobajdivestructuactfijcond> Motivobajdivestructuactfijconds { get; set; } = new List<Motivobajdivestructuactfijcond>();

    public virtual ICollection<Solicitudactivobaja> Solicitudactivobajas { get; set; } = new List<Solicitudactivobaja>();
}
