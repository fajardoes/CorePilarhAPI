using CorePilarh.Models.DTO;
using CorePilarh.Models.DTO.Serinsa;
using Microsoft.AspNetCore.Mvc;

namespace CorePilarh.Services.Seguros.Serinsa
{
    public interface ISerinsa
    {
        Task<ActionResult<object>> DevuelvePersona(DtoDevuelvePersonaRequest request);
        Task<ActionResult<object>> DevuelvePersonasFiltradas(DtoDevuelvePersonaRequest request);
    }
}
