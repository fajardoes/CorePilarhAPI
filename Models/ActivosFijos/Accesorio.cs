using System;
using System.Collections.Generic;

namespace CorePilarh.Models.ActivosFijos;

public partial class Accesorio
{
    public int Secuencial { get; set; }

    public int Secuencialactivo { get; set; }

    public string Descripcion { get; set; } = null!;

    public string Modelo { get; set; } = null!;

    public string Marca { get; set; } = null!;

    public string Numeroserie { get; set; } = null!;

    public string Codigousuario { get; set; } = null!;

    public DateTime Fechamaquina { get; set; }

    public DateTime Fechasistema { get; set; }

    public bool Estaactivo { get; set; }

    public int Numeroverificador { get; set; }

    public virtual AccesorioBaja? AccesorioBaja { get; set; }

    public virtual Activo SecuencialactivoNavigation { get; set; } = null!;
}
