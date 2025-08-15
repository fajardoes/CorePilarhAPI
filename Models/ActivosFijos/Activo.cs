using System;
using System.Collections.Generic;

namespace CorePilarh.Models.ActivosFijos;

public partial class Activo
{
    public int Secuencial { get; set; }

    public int Secuencialdivestructuraactfijo { get; set; }

    public int Numerosecuencial { get; set; }

    public DateTime Fechaadquisicion { get; set; }

    public decimal Costo { get; set; }

    public string Descripcion { get; set; } = null!;

    public int Secuencialpersonaresponsable { get; set; }

    public int Secuencialoficinadepartamento { get; set; }

    public int Secuencialmoneda { get; set; }

    public string Codigousuario { get; set; } = null!;

    public DateTime Fechamaquina { get; set; }

    public DateTime Fechasistema { get; set; }

    public string Codigocompuesto { get; set; } = null!;

    public string Codigoestadoactivo { get; set; } = null!;

    public string Codigoestadofisicoactivo { get; set; } = null!;

    public bool Esactivodiferido { get; set; }

    public int Numeroverificador { get; set; }

    public bool Eseventual { get; set; }

    public virtual ICollection<Accesorio> Accesorios { get; set; } = new List<Accesorio>();

    public virtual ActivoActivacion? ActivoActivacion { get; set; }

    public virtual ActivoActivodiferido? ActivoActivodiferido { get; set; }

    public virtual ActivoArea? ActivoArea { get; set; }

    public virtual ActivoBaja? ActivoBaja { get; set; }

    public virtual ActivoDepreciadototal? ActivoDepreciadototal { get; set; }

    public virtual ICollection<Activoadjunto> Activoadjuntos { get; set; } = new List<Activoadjunto>();

    public virtual ICollection<Activobooleana> Activobooleanas { get; set; } = new List<Activobooleana>();

    public virtual ICollection<Activocaracteristicalistum> Activocaracteristicalista { get; set; } = new List<Activocaracteristicalistum>();

    public virtual ICollection<ActivoeventualGaranthipotecar> ActivoeventualGaranthipotecars { get; set; } = new List<ActivoeventualGaranthipotecar>();

    public virtual ICollection<ActivoeventualGarantprendarium> ActivoeventualGarantprendaria { get; set; } = new List<ActivoeventualGarantprendarium>();

    public virtual ICollection<Activofecha> Activofechas { get; set; } = new List<Activofecha>();

    public virtual Activoinformacionanterior? Activoinformacionanterior { get; set; }

    public virtual ICollection<Activomejora> Activomejoras { get; set; } = new List<Activomejora>();

    public virtual ICollection<Activonumerica> Activonumericas { get; set; } = new List<Activonumerica>();

    public virtual ICollection<Activooficinaprorrateo> Activooficinaprorrateos { get; set; } = new List<Activooficinaprorrateo>();

    public virtual ICollection<Activotexto> Activotextos { get; set; } = new List<Activotexto>();

    public virtual ICollection<Avaluo> Avaluos { get; set; } = new List<Avaluo>();

    public virtual ICollection<Calculo> Calculos { get; set; } = new List<Calculo>();

    public virtual Estadoactivo CodigoestadoactivoNavigation { get; set; } = null!;

    public virtual Estadofisicoactivo CodigoestadofisicoactivoNavigation { get; set; } = null!;

    public virtual ICollection<Controldetalle> Controldetalles { get; set; } = new List<Controldetalle>();

    public virtual Oficinadepartamento SecuencialoficinadepartamentoNavigation { get; set; } = null!;

    public virtual PersonaResponsable SecuencialpersonaresponsableNavigation { get; set; } = null!;

    public virtual ICollection<Solicitudactivobaja> Solicitudactivobajas { get; set; } = new List<Solicitudactivobaja>();

    public virtual ICollection<Trasladodetalle> Trasladodetalles { get; set; } = new List<Trasladodetalle>();
}
