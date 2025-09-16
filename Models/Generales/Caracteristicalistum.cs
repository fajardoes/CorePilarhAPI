using System;
using System.Collections.Generic;

namespace GestionesPilarh.Models.Generales;

public partial class Caracteristicalistum
{
    public int Secuencial { get; set; }

    public string Codigocaracteristica { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public int Orden { get; set; }

    public decimal Peso { get; set; }

    public bool Estaactivo { get; set; }

    public int Numeroverificador { get; set; }

    public virtual Caracteristica CodigocaracteristicaNavigation { get; set; } = null!;

    public virtual ICollection<Divisioncaracteristicalistum> Divisioncaracteristicalista { get; set; } = new List<Divisioncaracteristicalistum>();
}
