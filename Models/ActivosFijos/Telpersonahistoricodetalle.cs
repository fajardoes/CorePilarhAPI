using System;
using System.Collections.Generic;

namespace GestionesPilarh.Models.ActivosFijos;

public partial class Telpersonahistoricodetalle
{
    public int Secuencial { get; set; }

    public int Sectelefonopersonahistorico { get; set; }

    public string Nombreempresatelefonica { get; set; } = null!;

    public string Nombretipotelefono { get; set; } = null!;

    public string Numerotelefono { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public bool Enviosms { get; set; }

    public bool Estaactivo { get; set; }

    public virtual Telefonopersonahistorico SectelefonopersonahistoricoNavigation { get; set; } = null!;
}
