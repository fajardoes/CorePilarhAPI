using Org.BouncyCastle.Bcpg;

namespace GestionesPilarh.Models.DTO.ActivosFijos
{
    public class DtoActivo
    {
        public int SecuencialDivisionEstructuraActivoFijo { get; set; } = 0;
        public DateTime FechaAdquisicion { get; set; } = DateTime.Now;
        public decimal Costo { get; set; } = decimal.Zero;
        public string Descripcion { get; set; } = string.Empty;
        public int SecuencialPersonaResponsable { get; set; } = 0;
        public int SecuencialOficinaDepartamento { get; set; } = 0;
        public int SecuencialMoneda { get; set; } = 0;
        public string CodigoUsuario { get; set; } = string.Empty;
        public DateTime FechaMaquina { get; set; } = DateTime.Now;
        public DateTime FechaSistema { get; set; } = DateTime.Now;
        public string CodigoCompuesto { get; set; } = string.Empty;
        public string CodigoEstadoActivo { get; set; } = string.Empty;
        public string CodigoEstadoFisicoActivo { get; set; } = string.Empty;
        public bool EsActivoDiferido { get; set; } = false;
        public bool EsEventual { get; set; } = false;
        public int SecuencialArea { get; set; } = 0;
        public int SecuencialOficina { get; set; } = 0;
        public List<DtoActivoAttachments> Attachments { get; set; } = new List<DtoActivoAttachments>();

    }
    public class DtoPersonaResponsable
    {
        public int SecuencialPersona { get; set; } = 0;
        public string NombreCompleto { get; set; } = string.Empty;

    }
    public class DtoOficina
    {
        public int SecuencialOficina { get; set; } = 0;
        public string Oficina { get; set; } = string.Empty;
    }

    //public class DtoPersonaResponsable
    //{
    //    public int SecuencialPersona { get; set; } = 0;
    //    public int SecuencialOficinaDpto { get; set; } = 0;
    //    public int SecuencialDpto { get; set; } = 0;
    //    public int SecuencialOficina { get; set; } = 0;
    //    public string Identificacion { get; set; } = string.Empty;
    //    public string NombreCompleto { get; set; } = string.Empty;
    //    public string Oficina {  get; set; } = string.Empty;
    //    public string Dpto { get; set; } = string.Empty; 

    //}
    public class DtoAreas
    {
        public int SecuencialOficinaArea { get; set; } = 0;
        public int SecuencialOficina { get; set; } = 0;
        public int SecuencialArea { get; set; } = 0;
        public string CodigoArea { get; set; } = string.Empty;
        public string NombreArea { get; set; } = string.Empty;
    }
    public class DtoEstadoActivo
    {
        public string Codigo { get; set; } = string.Empty;
        public string Nombre { get; set; } = string.Empty;
        public bool EstaActivo { get; set; } = false;
    }
    public class DtoActivoRespuesta
    {
        public string Message { get; set; } = string.Empty;
        public int Code { get; set; } = 0;
    }
    public class DtoActivoAttachments
    {
        public int Secuencial { get; set; } = 0;
        public int SecuencialActivo { get; set; } = 0;
        public string FileName { get; set; } = string.Empty;
        public string ContentType { get; set; } = string.Empty;
        public byte[] FileData { get; set; } = new byte[0];
        public DateTime FechaRegistro { get; set; } = DateTime.MinValue;
    }
    public class DtoActivoListado
    {
        public int Secuencial { get; set; } = 0;
        public string CodigoCompuesto { get; set; } = string.Empty;
        public DateTime FechaAdquisicion { get; set; } = DateTime.MinValue;
        public decimal Costo { get; set; } = 0;
        public string Descripcion { get; set; } = string.Empty;
        public string Estado { get; set; } = string.Empty;
        public string EstadoFisico { get; set; } = string.Empty;
        public string Oficina { get; set; } = string.Empty;
        public string Departamento { get; set; } = string.Empty;
        public string Responsable { get; set; } = string.Empty;
    }
    public class DtoActivoControl
    {
        public int Id { get; set; } = 0;
        public DateTime Fecha { get; set; } = DateTime.MinValue;
        public string Descripcion { set; get; } = string.Empty;
        public int Estado { get; set; } = 0;
        public int SecuencialOficina { get; set; } = 0;
        public DateTime FechaCliente { get; set; } = DateTime.MinValue;
        public string CodigoUsuario { get; set; } = string.Empty;
        public bool Activo { get; set; } = false;
    }
    public class DtoActivoControlDetalle
    {
        public int Id { get; set; } = 0;
        public int IdControl { get; set; } = 0;
        public int SecuencialActivo { get; set; } = 0;
        public string Descripcion { get; set; } = string.Empty;
        public string CodigoUsuario { set; get; } = string.Empty;
        public bool Activo { get; set; } = false;
        public DateTime FechaCliente { set; get; } = DateTime.MinValue;
    }

}
