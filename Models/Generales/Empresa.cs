using System;
using System.Collections.Generic;

namespace GestionesPilarh.Models.Generales;
public partial class Empresa
{
    public int Secuencial { get; set; }

    public string Siglas { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public string Codigooficinacontrol { get; set; } = null!;

    public int Secuencialmonedaoficial { get; set; }

    public string Codigopais { get; set; } = null!;

    public bool Estaactiva { get; set; }

    public int Numeroverificador { get; set; }

    public virtual ICollection<Bancoempresa> Bancoempresas { get; set; } = new List<Bancoempresa>();

    public virtual ICollection<Calendario> Calendarios { get; set; } = new List<Calendario>();

    public virtual ICollection<Calificacionriesgomicrofactoring> Calificacionriesgomicrofactorings { get; set; } = new List<Calificacionriesgomicrofactoring>();

    public virtual Pai CodigopaisNavigation { get; set; } = null!;

    public virtual ICollection<Empofiperfiscalgenactacomi> Empofiperfiscalgenactacomis { get; set; } = new List<Empofiperfiscalgenactacomi>();

    public virtual EmpresaDocumento? EmpresaDocumento { get; set; }

    public virtual EmpresaInformacioncontacto? EmpresaInformacioncontacto { get; set; }

    public virtual EmpresaInformacionsri? EmpresaInformacionsri { get; set; }

    public virtual EmpresaNumcertifireten? EmpresaNumcertifireten { get; set; }

    public virtual EmpresaParametrobusquedacli? EmpresaParametrobusquedacli { get; set; }

    public virtual EmpresaParametrodivisiongeo? EmpresaParametrodivisiongeo { get; set; }

    public virtual EmpresaParametrolog? EmpresaParametrolog { get; set; }

    public virtual EmpresaParametromensajerium? EmpresaParametromensajerium { get; set; }

    public virtual EmpresaParametrooficonsoli? EmpresaParametrooficonsoli { get; set; }

    public virtual EmpresaParametroplandecuenta? EmpresaParametroplandecuenta { get; set; }

    public virtual EmpresaParametroporcentajeiva? EmpresaParametroporcentajeiva { get; set; }

    public virtual EmpresaParametroreposentencium? EmpresaParametroreposentencium { get; set; }

    public virtual ICollection<EmpresaUsuariodocumento> EmpresaUsuariodocumentos { get; set; } = new List<EmpresaUsuariodocumento>();

    public virtual ICollection<Empresaimagenpersona> Empresaimagenpersonas { get; set; } = new List<Empresaimagenpersona>();

    public virtual Monedum SecuencialmonedaoficialNavigation { get; set; } = null!;

    public virtual ICollection<TipodivisionEmpresa> TipodivisionEmpresas { get; set; } = new List<TipodivisionEmpresa>();
}
