using System;
using System.Collections.Generic;

namespace GestionesPilarh.Models.Generales;

public partial class EmpresaParametrodivisiongeo
{
    public int Secuencialempresa { get; set; }

    public int? Secuencialnivelrequeridonacimi { get; set; }

    public int? Secuencialnivelrequeridoreside { get; set; }

    public int? Numeroverificador { get; set; }

    public virtual Empresa SecuencialempresaNavigation { get; set; } = null!;

    public virtual Niveldivision? SecuencialnivelrequeridonacimiNavigation { get; set; }

    public virtual Niveldivision? SecuencialnivelrequeridoresideNavigation { get; set; }
}
