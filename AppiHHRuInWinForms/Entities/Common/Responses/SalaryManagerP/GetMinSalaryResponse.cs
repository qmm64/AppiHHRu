using AppiHHRuInWinForms;
using AppiHHRuInWinForms.Entities.Common;

namespace AppiHHRuInWinForms.Entities.Common.Responses.SalaryManagerP
{
    public record GetMinSalaryResponse(bool IsSuccess, long MinSalary = -1);
}