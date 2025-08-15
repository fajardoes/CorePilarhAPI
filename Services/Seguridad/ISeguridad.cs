using CorePilarh.Models.DTO;
using Microsoft.AspNetCore.Mvc;

namespace CorePilarh.Services.Seguridad
{
    public interface ISeguridad
    {
        Task<ActionResult<object>> ValidateUser(DtoValidateUserRequest request);
        Task<IEnumerable<dynamic>> GetMenus();
        Task<ActionResult<object>> ValidateToken(DtoValidateUserRequest request);
    }
}
