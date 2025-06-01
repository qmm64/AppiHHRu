namespace AppiHHRuInWinForms.Entities.Common.Responses.SalaryManagerP
{
    public record GetSalaryResponse(bool IsSuccess, List<string> Salaries = null);
}