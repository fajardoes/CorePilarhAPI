using GestionesPilarh.Models.DTO;
using Microsoft.AspNetCore.Mvc;

namespace GestionesPilarh.Services.Logger
{
    public interface ILoggerAPI
    {
         Task<ActionResult<object>> LogAction(LogsDto request);

    }
}
