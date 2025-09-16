using System;
using System.Collections.Generic;

namespace GestionesPilarh.Models.Generales;

public partial class Tipodivision
{
    public int Secuencial { get; set; }

    public string Codigo { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public bool Estaactivo { get; set; }

    public int Numeroverificador { get; set; }

    public virtual ICollection<EmpresaParametroplandecuenta> EmpresaParametroplandecuenta { get; set; } = new List<EmpresaParametroplandecuenta>();

    public virtual ICollection<Niveldivision> Niveldivisions { get; set; } = new List<Niveldivision>();

    public virtual ICollection<Pai> Pais { get; set; } = new List<Pai>();

    public virtual ICollection<TipodivisionEmpresa> TipodivisionEmpresas { get; set; } = new List<TipodivisionEmpresa>();
}
