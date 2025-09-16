using System;
using System.Collections.Generic;

namespace GestionesPilarh.Models.Generales;
public partial class Empofiperfiscalgenactacomi
{
    public int Secuencial { get; set; }

    public int Secuencialempresa { get; set; }

    public int Secuencialoficina { get; set; }

    public int Periodofiscal { get; set; }

    public int Ultimosecuencialactacomite { get; set; }

    public bool Estaactivo { get; set; }

    public int Numeroverificador { get; set; }

    public virtual Empresa SecuencialempresaNavigation { get; set; } = null!;
}
