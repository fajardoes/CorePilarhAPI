using CorePilarh.Models.DTO.ActivosFijos;
using Microsoft.AspNetCore.Mvc;

namespace CorePilarh.Services.ActivosFijos
{
    public interface IActivosFijos
    {
        Task<IEnumerable<dynamic>> GetAFStructure(int SecTipoDivision);
        Task<string> GeneraCodigoActivo(int? secuencialDivision);
        Task<IEnumerable<dynamic>> ObtenerPersonasResponsables(string secuencialOficina);
        Task<IEnumerable<dynamic>> ObtenerOficinas();
        Task<IEnumerable<dynamic>> ObtenerAreas(int SecOficina);
        Task<IEnumerable<dynamic>> ObtenerEstadoActivo();
        Task<ActionResult<object>> GuardarActivo(DtoActivo request);
        Task<ActionResult<dynamic>> GuardarControlActivo(DtoActivoControl request);
        Task<ActionResult<dynamic>> ActualizaControlActivo(DtoActivoControl request);
        Task<ActionResult<dynamic>> GuardarControlActivoDetalle(DtoActivoControlDetalle request);
        Task<IEnumerable<dynamic>> ObtenerControlActivos(List<int>? oficinasID = null, DateTime? fecha = null);
        Task<IEnumerable<dynamic>> ObtenerActivosFijos(string secuencialResponsable);
        Task<IEnumerable<dynamic>> ObtenerActivoByCode(string code);
        Task<IEnumerable<dynamic>> ObtenerControlActivosByEstado(int estado);
        Task<IEnumerable<dynamic>> ObtenerControlDetalle(int controlId);
        Task<ActionResult<dynamic>> ActualizaEstadoControlActivo(int controlId, int estado);
        Task<ActionResult<object>> EliminaControlActivoDetalle(int activoDetalleId);
    }
}
