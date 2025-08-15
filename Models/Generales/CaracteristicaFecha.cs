using System;
using System.Collections.Generic;

namespace CorePilarh.Models.Generales;

public partial class CaracteristicaFecha
{
    public string Codigocaracteristica { get; set; } = null!;

    public DateTime Fechainicio { get; set; }

    public DateTime Fechafin { get; set; }

    public string Formatofecha { get; set; } = null!;

    public DateTime Fechadefecto { get; set; }

    public bool Estaactivo { get; set; }

    public int Numeroverificador { get; set; }

    public virtual Caracteristica CodigocaracteristicaNavigation { get; set; } = null!;
}
