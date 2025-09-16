using GestionesPilarh.Models.DTO;
using GestionesPilarh.Models.DTO.Serinsa;
using Microsoft.AspNetCore.Mvc;

namespace GestionesPilarh.Services.Seguros.Serinsa
{
    public interface ISerinsa
    {
        Task<ActionResult<object>> DevuelvePersona(DtoDevuelvePersonaRequest request);
        Task<ActionResult<object>> DevuelvePersonasFiltradas(DtoDevuelvePersonaRequest request);
    }
}
