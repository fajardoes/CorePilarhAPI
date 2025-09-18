using System;
using System.Collections.Generic;

namespace GestionesPilarh.Models.ActivosFijos;

public partial class PersonaNaturalocupacionGeolocation
{
    public int Secuencial { get; set; }

    public int? SecuencialpersonaNaturalocupacion { get; set; }

    public string Latitud { get; set; } = null!;

    public string Longitud { get; set; } = null!;

    public string Direccion { get; set; } = null!;

    public string Uuid { get; set; } = null!;

    public string Parroquia { get; set; } = null!;

    public string Referencia { get; set; } = null!;

    public bool Estaactivo { get; set; }

    public int Numeroverificador { get; set; }
}
