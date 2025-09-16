using System;
using System.Collections.Generic;

namespace GestionesPilarh.Models.Generales;
public partial class EmpresaParametrooficonsoli
{
    public int Secuencialempresa { get; set; }

    public int Secuencialoficinaconsolidado { get; set; }

    public bool Esprincipal { get; set; }

    public int Numeroverificador { get; set; }

    public virtual Empresa SecuencialempresaNavigation { get; set; } = null!;

    public virtual Division SecuencialoficinaconsolidadoNavigation { get; set; } = null!;
}
