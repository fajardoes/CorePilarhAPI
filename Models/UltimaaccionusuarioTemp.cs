using System;
using System.Collections.Generic;

namespace CorePilarh.Models;

public partial class UltimaaccionusuarioTemp
{
    public int Secuencial { get; set; }

    public string Codigousuario { get; set; } = null!;

    public string Maquinaingreso { get; set; } = null!;

    public DateTime Fechasistema { get; set; }

    public DateTime Fechamaquina { get; set; }

    public string Codigoaccion { get; set; } = null!;

    public string Descripcionaccion { get; set; } = null!;

    public string Criptografiaregistro { get; set; } = null!;

    public string? Agencia { get; set; }

    public string? Ipmaquina { get; set; }

    public string? Numoperaafectada { get; set; }

    public string? Nombrecliente { get; set; }

    public string? Modulo { get; set; }

    public string? Pantalla { get; set; }
}
