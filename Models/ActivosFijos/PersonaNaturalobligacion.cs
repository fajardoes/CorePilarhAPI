using System;
using System.Collections.Generic;

namespace GestionesPilarh.Models.ActivosFijos;

public partial class PersonaNaturalobligacion
{
    public int Secuencial { get; set; }

    public int Secuencialpersonanatural { get; set; }

    public string Entidad { get; set; } = null!;

    public decimal Montoprestado { get; set; }

    public int Plazo { get; set; }

    public decimal Valorcuota { get; set; }

    public decimal Saldoactual { get; set; }

    public DateTime Fechavencimiento { get; set; }

    public string Garantia { get; set; } = null!;

    public string Formapago { get; set; } = null!;

    public bool Estaactivo { get; set; }

    public int Numeroverificador { get; set; }

    public virtual PersonaNatural SecuencialpersonanaturalNavigation { get; set; } = null!;
}
