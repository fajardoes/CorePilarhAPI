using System;
using System.Collections.Generic;

namespace GestionesPilarh.Models.ActivosFijos;

public partial class ActivoBaja
{
    public int Secuencialactivo { get; set; }

    public string? Motivo { get; set; }

    public DateTime Fechabaja { get; set; }

    public string Codigousuario { get; set; } = null!;

    public DateTime Fechamaquina { get; set; }

    public DateTime Fechasistema { get; set; }

    public string Detalleautorizacion { get; set; } = null!;

    public int Secuencialmotivobaja { get; set; }

    public virtual Activo SecuencialactivoNavigation { get; set; } = null!;

    public virtual MotivoActivobaja SecuencialmotivobajaNavigation { get; set; } = null!;
}
