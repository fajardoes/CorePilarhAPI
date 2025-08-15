using System;
using System.Collections.Generic;

namespace CorePilarh.Models.Generales;

public partial class EmpresaParametroporcentajeiva
{
    public int Secuencialempresa { get; set; }

    public string Codigousuarioregistra { get; set; } = null!;

    public DateTime Fechasistemaingreso { get; set; }

    public DateTime Fechamaquinaingreso { get; set; }

    public decimal Porcentaje { get; set; }

    public int Numeroverificador { get; set; }

    public virtual Empresa SecuencialempresaNavigation { get; set; } = null!;
}
