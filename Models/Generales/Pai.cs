using System;
using System.Collections.Generic;

namespace GestionesPilarh.Models.Generales;

public partial class Pai
{
    public string Codigo { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public int Secuencialtipodivisionpolitica { get; set; }

    public bool Estaactivo { get; set; }

    public int Numeroverificador { get; set; }

    public string? Nacionalidad { get; set; }

    public virtual ICollection<Empresa> Empresas { get; set; } = new List<Empresa>();

    public virtual ICollection<Empresatelefonica> Empresatelefonicas { get; set; } = new List<Empresatelefonica>();

    public virtual ICollection<Monedum> Moneda { get; set; } = new List<Monedum>();

    public virtual Tipodivision SecuencialtipodivisionpoliticaNavigation { get; set; } = null!;
}
