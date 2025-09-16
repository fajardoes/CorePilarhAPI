using System;
using System.Collections.Generic;

namespace GestionesPilarh.Models.ActivosFijos;

public partial class Activobooleana
{
    public int Secuencial { get; set; }

    public int Secuencialactivo { get; set; }

    public string Codigocaracteristica { get; set; } = null!;

    public bool Valor { get; set; }

    public bool Estaactivo { get; set; }

    public int Numeroverificador { get; set; }

    public virtual Activo SecuencialactivoNavigation { get; set; } = null!;
}
