using CorePilarh.Models.DTO;
using Microsoft.AspNetCore.Mvc;

namespace CorePilarh.Services.LoggerAPI
{
    public interface ILoggerAPI
    {
         Task<ActionResult<object>> LogAction(LogsDto request);

    }
}
