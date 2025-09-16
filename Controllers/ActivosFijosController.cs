using GestionesPilarh.Models.DTO.ActivosFijos;
using GestionesPilarh.Models.Generales;
using GestionesPilarh.Services.ActivosFijos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace GestionesPilarh.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ActivosFijosController(IActivosFijos activosFijos) : ControllerBase
    {
        private readonly IActivosFijos _serviceActivosFijos = activosFijos;

        #region Listas
        [HttpGet("GetAFStructure/{SecTipoDivision}")]
        public async Task<ActionResult> GetAFStructure(int SecTipoDivision)
        {
            try
            {
                var lista = await _serviceActivosFijos.GetAFStructure(SecTipoDivision);
                return Ok(lista);
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
        [HttpGet("ObtenerPersonasResponsables/{secuencialOficina}")]
        public async Task<ActionResult> ObtenerPersonasResponsables(string secuencialOficina)
        {
            try
            {
                var lista = await _serviceActivosFijos.ObtenerPersonasResponsables(secuencialOficina);
                return Ok(lista);
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
        [HttpGet("ObtenerOficinas")]
        public async Task<ActionResult> ObtenerOficinas()
        {
            try
            {
                var lista = await _serviceActivosFijos.ObtenerOficinas();
                return Ok(lista);
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
        [HttpGet("ObtenerAreas/{SecOficina}")]
        public async Task<ActionResult> ObtenerAreas(int SecOficina)
        {
            try
            {
                var lista = await _serviceActivosFijos.ObtenerAreas(SecOficina);
                return Ok(lista);
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
        [HttpGet("ObtenerEstadoActivo")]
        public async Task<ActionResult> ObtenerEstadoActivo()
        {
            try
            {
                var lista = await _serviceActivosFijos.ObtenerEstadoActivo();
                return Ok(lista);
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
        [HttpGet("ObtenerActivosFijos/{secuencialResponsable}")]
        public async Task<ActionResult> ObtenerActivosFijos(string secuencialResponsable )
        {
            try
            {
                var lista = await _serviceActivosFijos.ObtenerActivosFijos(secuencialResponsable);
                return Ok(lista);
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
        [HttpGet("ObtenerControlActivos")]
        public async Task<ActionResult> ObtenerControlActivos([FromQuery] List<int>? oficinasId = null, DateTime? fecha = null)
        {
            try
            {
                var lista = await _serviceActivosFijos.ObtenerControlActivos(oficinasId, fecha);
                return Ok(lista);
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
        [HttpGet("ObtenerActivoByCode/{code}")]
        public async Task<ActionResult> ObtenerActivoByCode(string code)
        {
            try
            {
                var lista = await _serviceActivosFijos.ObtenerActivoByCode(code);
                return Ok(lista);
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
        [HttpGet("ObtenerControlActivosByEstado/{estado}")]
        public async Task<ActionResult> ObtenerControlActivosByEstado(int estado)
        {
            try
            {
                var lista = await _serviceActivosFijos.ObtenerControlActivosByEstado(estado);
                return Ok(lista);
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
        [HttpGet("ObtenerControlDetalle/{controlId}")]
        public async Task<ActionResult> ObtenerControlDetalle(int controlId)
        {
            try
            {
                var lista = await _serviceActivosFijos.ObtenerControlDetalle(controlId);
                return Ok(lista);
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

        #endregion
        [HttpGet("GeneraCodigoActivo/{secuencial}")]
        public async Task<ActionResult> GeneraCodigoActivo(int secuencial)
        {
            try
            {
                string codigo = await _serviceActivosFijos.GeneraCodigoActivo(secuencial);
                return Ok(codigo);
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
        [HttpPost("GuardarActivo")]
        public async Task<ActionResult<object>> GuardarActivo([FromBody] DtoActivo request)
        {
            try
            {
                return await _serviceActivosFijos.GuardarActivo(request);
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
        [HttpPost("GuardarControlActivo")]
        public async Task<ActionResult<object>> GuardarControlActivo([FromBody] DtoActivoControl request)
        {
            try
            {
                return await _serviceActivosFijos.GuardarControlActivo(request);
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
        [HttpPut("ActualizaControlActivo")]
        public async Task<ActionResult<object>> ActualizaControlActivo([FromBody] DtoActivoControl request)
        {
            try
            {
                return await _serviceActivosFijos.ActualizaControlActivo(request);
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
        [HttpPut("ActualizaEstadoControlActivo/{controlId}/{estado}")]
        public async Task<ActionResult<object>> ActualizaEstadoControlActivo(int controlId, int estado)
        {
            try
            {
                return await _serviceActivosFijos.ActualizaEstadoControlActivo(controlId, estado);
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
        [HttpPost("GuardarControlActivoDetalle")]
        public async Task<ActionResult<object>> GuardarControlActivoDetalle([FromBody] DtoActivoControlDetalle request)
        {
            try
            {
                return await _serviceActivosFijos.GuardarControlActivoDetalle(request);
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
        [HttpPut("ActualizaControlActivoDetalle")]
        public async Task<ActionResult<object>> ActualizaControlActivoDetalle([FromBody] DtoActivoControlDetalle request)
        {
            try
            {
                return await _serviceActivosFijos.ActualizaControlActivoDetalle(request);
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
        [HttpDelete("EliminaControlActivoDetalle/{activoDetalleId}")]
        [Authorize]
        public async Task<ActionResult<object>> EliminaControlActivoDetalle(int activoDetalleId)
        {
            try
            {
                return await _serviceActivosFijos.EliminaControlActivoDetalle(activoDetalleId);
            }
            catch (Exception ex)
            {
                var errorResponse = new
                {
                    message = "Error: " + ex?.InnerException?.Message.ToString(),
                    code = 400
                };
                return BadRequest(errorResponse);
            }
        }
    }
}
