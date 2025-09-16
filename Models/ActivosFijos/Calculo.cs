using System;
using System.Collections.Generic;

namespace GestionesPilarh.Models.ActivosFijos;

public partial class Calculo
{
    public int Secuencial { get; set; }

    public int Secuencialactivo { get; set; }

    public DateTime Fechacalculo { get; set; }

    public DateTime Fechamaquina { get; set; }

    public decimal Valoranterior { get; set; }

    public decimal Incremento { get; set; }

    public decimal Indicecorreccion { get; set; }

    public decimal Porcentajedepreciacionperiodo { get; set; }

    public decimal Porctjdepreciacionacumulada { get; set; }

    public string Codigousuario { get; set; } = null!;

    public decimal Depreciacionacumulada { get; set; }

    public decimal Depreciacionperiodo { get; set; }

    public decimal Saldolibros { get; set; }

    public bool Estadepreciadototal { get; set; }

    public virtual ICollection<Calculooficinacalculo> Calculooficinacalculos { get; set; } = new List<Calculooficinacalculo>();

    public virtual Activo SecuencialactivoNavigation { get; set; } = null!;
}
