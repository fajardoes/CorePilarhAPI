using System;
using System.Collections.Generic;

namespace GestionesPilarh.Models.Generales;

public partial class Caracteristica
{
    public string Codigo { get; set; } = null!;

    public string? Nombre { get; set; }

    public bool Estaactivo { get; set; }

    public int Numeroverificador { get; set; }

    public bool? Esobligatorio { get; set; }

    public int? Orden { get; set; }

    public virtual CaracteristicaBooleana? CaracteristicaBooleana { get; set; }

    public virtual CaracteristicaFecha? CaracteristicaFecha { get; set; }

    public virtual CaracteristicaNumerica? CaracteristicaNumerica { get; set; }

    public virtual CaracteristicaTexto? CaracteristicaTexto { get; set; }

    public virtual ICollection<Caracteristicalistum> Caracteristicalista { get; set; } = new List<Caracteristicalistum>();

    public virtual ICollection<Caracteristicalistamultiple> Caracteristicalistamultiples { get; set; } = new List<Caracteristicalistamultiple>();

    public virtual ICollection<Caracteristicatipocaracterist> Caracteristicatipocaracterists { get; set; } = new List<Caracteristicatipocaracterist>();

    public virtual ICollection<Divisionbooleana> Divisionbooleanas { get; set; } = new List<Divisionbooleana>();

    public virtual ICollection<Divisionfecha> Divisionfechas { get; set; } = new List<Divisionfecha>();

    public virtual ICollection<Divisionnumerica> Divisionnumericas { get; set; } = new List<Divisionnumerica>();

    public virtual ICollection<Divisiontexto> Divisiontextos { get; set; } = new List<Divisiontexto>();
}
