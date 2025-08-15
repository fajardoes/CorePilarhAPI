using System;
using System.Collections.Generic;

namespace CorePilarh.Models.ActivosFijos;

public partial class Oficina
{
    public int Secuencialdivision { get; set; }

    public int Secuencialempresa { get; set; }

    public string Codigooficinacontrol { get; set; } = null!;

    public string Siglas { get; set; } = null!;

    public string Ciudad { get; set; } = null!;

    public int Numerocontable { get; set; }

    public bool Esoperativa { get; set; }

    public DateTime Fechacierrecontable { get; set; }

    public string Cadenaconexionbasedatoslocal { get; set; } = null!;

    public string Servidorimagenes { get; set; } = null!;

    public bool Estaactiva { get; set; }

    public int Numeroverificador { get; set; }

    public string Servidorswitch { get; set; } = null!;

    public int Puertoswitch { get; set; }

    public bool Desconectada { get; set; }

    public virtual ICollection<Activooficinaprorrateo> Activooficinaprorrateos { get; set; } = new List<Activooficinaprorrateo>();

    public virtual ICollection<Calculooficina> Calculooficinas { get; set; } = new List<Calculooficina>();

    public virtual ICollection<Control> Controls { get; set; } = new List<Control>();

    public virtual OficinaComplemento? OficinaComplemento { get; set; }

    public virtual OficinaComplementosri? OficinaComplementosri { get; set; }

    public virtual OficinaFirmante? OficinaFirmante { get; set; }

    public virtual OficinaGeolocalizacion? OficinaGeolocalizacion { get; set; }

    public virtual ICollection<Oficinaarea> Oficinaareas { get; set; } = new List<Oficinaarea>();

    public virtual ICollection<Oficinadepartamento> Oficinadepartamentos { get; set; } = new List<Oficinadepartamento>();

    public virtual ICollection<Oficinapdum> Oficinapda { get; set; } = new List<Oficinapdum>();

    public virtual ICollection<Oficinapuntoventum> Oficinapuntoventa { get; set; } = new List<Oficinapuntoventum>();

    public virtual Oficinazona? Oficinazona { get; set; }

    public virtual ICollection<Solicitudactivobaja> Solicitudactivobajas { get; set; } = new List<Solicitudactivobaja>();
}
