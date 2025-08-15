using CorePilarh.Models.DTO;
using CorePilarh.Models.DTO.Finanzas;
using CorePilarh.Services.Seguridad;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CorePilarh.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SeguridadController(ISeguridad seguridad) : ControllerBase
    {
        private readonly ISeguridad _seguridad = seguridad;

        [HttpPost("ValidateUser")]
        public async Task<ActionResult<object>> ValidateUser([FromBody] DtoValidateUserRequest request)
        {
            try
            {
                var data = await _seguridad.ValidateUser(request);
                return data;
            }
            catch (Exception ex)
            {
                var errorResponse = new
                {
                    message = "Error: " + ex.Message,
                    code = 400
                };
                var jsonError = JsonConvert.SerializeObject(errorResponse);
                return BadRequest(jsonError);
            }
        }
        [HttpGet("GetMenus")]
        [Authorize]
        public async Task<IActionResult> GetMenus()
        {
            try
            {
                var menus = await _seguridad.GetMenus();
                return Ok(menus);
            }
            catch (Exception ex)
            {
                var errorResponse = new
                {
                    message = "Error: " + ex.Message,
                    code = 400
                };
                var jsonError = JsonConvert.SerializeObject(errorResponse);
                return BadRequest(jsonError);
            }
        }
        [HttpPost("ValidateToken")]
        public async Task<ActionResult<object>> ValidateToken([FromBody] DtoValidateUserRequest request)
        {
            try
            {
                var data = await _seguridad.ValidateToken(request);
                return data;
            }
            catch (Exception ex)
            {
                var errorResponse = new
                {
                    message = "Error: " + ex.Message,
                    code = 400
                };
                var jsonError = JsonConvert.SerializeObject(errorResponse);
                return BadRequest(jsonError);
            }
        }
    }
}
