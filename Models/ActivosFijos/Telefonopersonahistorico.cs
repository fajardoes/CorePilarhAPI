using System;
using System.Collections.Generic;

namespace GestionesPilarh.Models.ActivosFijos;

public partial class Telefonopersonahistorico
{
    public int Secuencial { get; set; }

    public int Secuencialpersona { get; set; }

    public string Codigousuarioingreso { get; set; } = null!;

    public DateTime Fechasistema { get; set; }

    public DateTime Fechamaquina { get; set; }

    public bool Estaactivo { get; set; }

    public virtual ICollection<Telpersonahistoricodetalle> Telpersonahistoricodetalles { get; set; } = new List<Telpersonahistoricodetalle>();
}
