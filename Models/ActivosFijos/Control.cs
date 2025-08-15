using System;
using System.Collections.Generic;

namespace CorePilarh.Models.ActivosFijos;

/// <summary>
/// Tabla padre para gestion de control de activos fijos
/// </summary>
public partial class Control
{
    public int Id { get; set; }

    public DateTime Fecha { get; set; }

    public string Descripcion { get; set; } = null!;

    public int? Estado { get; set; }

    public int Secuencialoficina { get; set; }

    public DateTime? Fechacliente { get; set; }

    public string? Codigousuario { get; set; }

    public bool? Activo { get; set; }

    public virtual ICollection<Controldetalle> Controldetalles { get; set; } = new List<Controldetalle>();

    public virtual Oficina SecuencialoficinaNavigation { get; set; } = null!;
}
