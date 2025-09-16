using System;
using System.Collections.Generic;

namespace GestionesPilarh.Models.Generales;

public partial class Calificacionriesgomicrofactoring
{
    public string Codigo { get; set; } = null!;

    public int Secuencialempresa { get; set; }

    public string Nombre { get; set; } = null!;

    public bool Estaactivo { get; set; }

    public int Numeroverificador { get; set; }

    public virtual Empresa SecuencialempresaNavigation { get; set; } = null!;
}
