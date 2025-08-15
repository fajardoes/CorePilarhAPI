using System;
using System.Collections.Generic;

namespace CorePilarh.Models.Generales;

public partial class Empresaimagenpersona
{
    public int Secuencial { get; set; }

    public int Secuencialempresa { get; set; }

    public string Nombre { get; set; } = null!;

    public string Carpeta { get; set; } = null!;

    public string Extension { get; set; } = null!;

    public bool Estaactiva { get; set; }

    public int Numeroverificador { get; set; }

    public virtual Empresa SecuencialempresaNavigation { get; set; } = null!;
}
