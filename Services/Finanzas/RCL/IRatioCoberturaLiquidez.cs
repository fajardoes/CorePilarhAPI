using CorePilarh.Models.DTO.Finanzas;

namespace CorePilarh.Services.Finanzas.RCL
{
    public interface IRatioCoberturaLiquidez
    {
        Task<byte[]> GenerateExcelReport(DateTime startDate, DateTime endDate);
    }
}
