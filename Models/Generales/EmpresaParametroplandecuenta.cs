using System;
using System.Collections.Generic;

namespace GestionesPilarh.Models.Generales;
public partial class EmpresaParametroplandecuenta
{
    public int Secuencialempresa { get; set; }

    public int Secuencialtipodivisionplanctas { get; set; }

    public int Numeroverificador { get; set; }

    public virtual Empresa SecuencialempresaNavigation { get; set; } = null!;

    public virtual Tipodivision SecuencialtipodivisionplanctasNavigation { get; set; } = null!;
}
