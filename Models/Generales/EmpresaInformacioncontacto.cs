using System;
using System.Collections.Generic;

namespace GestionesPilarh.Models.Generales;

public partial class EmpresaInformacioncontacto
{
    public int Secuencialempresa { get; set; }

    public string Nombrecompleto { get; set; } = null!;

    public string Nit { get; set; } = null!;

    public string Direccion { get; set; } = null!;

    public int Numeroverificador { get; set; }

    public virtual Empresa SecuencialempresaNavigation { get; set; } = null!;
}
