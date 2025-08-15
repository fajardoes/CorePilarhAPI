using System;
using System.Collections.Generic;

namespace CorePilarh.Models.Generales;

public partial class Banco
{
    public int Secuencial { get; set; }

    public string Codigo { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public string Codigotipobanco { get; set; } = null!;

    public string? Nombrebancobeneficiario { get; set; }

    public string? Direccionbancobeneficiario { get; set; }

    public string? Swift { get; set; }

    public string? Aba { get; set; }

    public string? Fed { get; set; }

    public string? Chips { get; set; }

    public bool Estaactivo { get; set; }

    public int? Numeroverificador { get; set; }

    public virtual BancoFormatoestadoctaban? BancoFormatoestadoctaban { get; set; }

    public virtual ICollection<Bancoempresa> Bancoempresas { get; set; } = new List<Bancoempresa>();

    public virtual Tipobanco CodigotipobancoNavigation { get; set; } = null!;

    public virtual IdentificacionbancariaBanco? IdentificacionbancariaBanco { get; set; }
}
