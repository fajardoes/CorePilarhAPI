using System;
using System.Collections.Generic;

namespace GestionesPilarh.Models.ActivosFijos;

public partial class Traslado
{
    public int Secuencial { get; set; }

    public DateTime Fechasistema { get; set; }

    public DateTime Fechamaquina { get; set; }

    public string Codigousuario { get; set; } = null!;

    public string Concepto { get; set; } = null!;

    public string Codigoestadotraslado { get; set; } = null!;

    public int Numeroverificador { get; set; }

    public virtual ICollection<Trasladodetalle> Trasladodetalles { get; set; } = new List<Trasladodetalle>();
}
