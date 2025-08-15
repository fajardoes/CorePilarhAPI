using System;
using System.Collections.Generic;

namespace CorePilarh.Models.ActivosFijos;

/// <summary>
/// Tabla para registrar los activos dentro de cada control de agencias
/// </summary>
public partial class Controldetalle
{
    public int Id { get; set; }

    public int Idcontrol { get; set; }

    public int Secuencialactivo { get; set; }

    public string? Descripcion { get; set; }

    public string Codigousuario { get; set; } = null!;

    public bool? Activo { get; set; }

    public DateTime? Fechacliente { get; set; }

    public virtual Control IdcontrolNavigation { get; set; } = null!;

    public virtual Activo SecuencialactivoNavigation { get; set; } = null!;
}
