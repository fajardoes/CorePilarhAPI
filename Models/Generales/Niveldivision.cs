using System;
using System.Collections.Generic;

namespace GestionesPilarh.Models.Generales;
public partial class Niveldivision
{
    public int Secuencial { get; set; }

    public int Nivel { get; set; }

    public string Nombre { get; set; } = null!;

    public int Secuencialtipodivision { get; set; }

    public int Numeroverificador { get; set; }

    public virtual ICollection<Division> Divisions { get; set; } = new List<Division>();

    public virtual ICollection<EmpresaParametrodivisiongeo> EmpresaParametrodivisiongeoSecuencialnivelrequeridonacimiNavigations { get; set; } = new List<EmpresaParametrodivisiongeo>();

    public virtual ICollection<EmpresaParametrodivisiongeo> EmpresaParametrodivisiongeoSecuencialnivelrequeridoresideNavigations { get; set; } = new List<EmpresaParametrodivisiongeo>();

    public virtual Tipodivision SecuencialtipodivisionNavigation { get; set; } = null!;
}
