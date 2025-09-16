using GestionesPilarh.Models.DTO;
using Microsoft.AspNetCore.Mvc;

namespace GestionesPilarh.Services.Seguridad
{
    public interface ISeguridad
    {
        Task<ActionResult<object>> ValidateUser(DtoValidateUserRequest request);
        Task<IEnumerable<dynamic>> GetMenus();
        Task<ActionResult<object>> ValidateToken(DtoValidateUserRequest request);
    }
}
