using GestionesPilarh.Models.DTO.Finanzas;

namespace GestionesPilarh.Services.Finanzas.RCL
{
    public interface IRatioCoberturaLiquidez
    {
        Task<byte[]> GenerateExcelReport(DateTime startDate, DateTime endDate);
    }
}
