using CorePilarh.Models.DTO.Serinsa;
using CorePilarh.Services.Seguros.Serinsa;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CorePilarh.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SegurosController(ISerinsa serinsa) : ControllerBase
    {
        private readonly ISerinsa _serinsa = serinsa;

        [HttpPost("DevuelvePersona")]
        [Authorize]
        public async Task<ActionResult<object>> DevuelvePersona([FromBody] DtoDevuelvePersonaRequest request)
        {
            try
            {
                var datos = await _serinsa.DevuelvePersona(request);
                return datos;
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
                throw;
            }
        }
        [HttpPost("DevuelvePersonasFiltradas")]
        [Authorize]
        public async Task<ActionResult<object>> DevuelvePersonasFiltradas([FromBody] DtoDevuelvePersonaRequest request)
        {
            try
            {
                var datos = await _serinsa.DevuelvePersonasFiltradas(request);
                return datos;
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
                throw;
            }
        }
    }
}
