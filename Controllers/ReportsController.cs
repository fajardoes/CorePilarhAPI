using GestionesPilarh.Models.DTO.Finanzas;
using GestionesPilarh.Services.Finanzas.RCL;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace GestionesPilarh.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ReportsController(IRatioCoberturaLiquidez ratioCoberturaLiquidez) : ControllerBase
    {
        private readonly IRatioCoberturaLiquidez _ratioCoberturaLiquidez = ratioCoberturaLiquidez;

        [HttpGet("GetRCL/{startDate}/{endDate}")]
        public async Task<IActionResult> GetRCL(DateTime startDate, DateTime endDate)
        {
            try
            {
                if (startDate > endDate)
                {
                    var errorResponse = new
                    {
                        message = "Error: La fecha de inicio no puede ser mayor que la fecha de fin.",
                        code = 400
                    };
                    var jsonError = JsonConvert.SerializeObject(errorResponse);
                    return BadRequest(jsonError);
                }
                var excelData = await _ratioCoberturaLiquidez.GenerateExcelReport(startDate, endDate);
                var fileName = $"RCL_{startDate:yyyyMMdd}_{endDate:yyyyMMdd}.xlsx";

                return File(excelData, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", fileName);
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
