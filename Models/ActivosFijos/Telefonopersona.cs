using System;
using System.Collections.Generic;

namespace GestionesPilarh.Models.ActivosFijos;

public partial class Telefonopersona
{
    public int Secuencial { get; set; }

    public int Secuencialpersona { get; set; }

    public string Codigoempresatelefonica { get; set; } = null!;

    public string Codigotipotelefono { get; set; } = null!;

    public string Numerotelefono { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public bool Estaactivo { get; set; }

    public int Numeroverificador { get; set; }

    public bool? Enviosms { get; set; }

    public virtual Persona SecuencialpersonaNavigation { get; set; } = null!;
}
