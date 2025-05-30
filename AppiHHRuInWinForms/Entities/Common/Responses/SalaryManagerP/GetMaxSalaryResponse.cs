using AppiHHRuInWinForms;
using AppiHHRuInWinForms.Entities.Common;

namespace AppiHHRuInWinForms.Entities.Common.Responses.SalaryManagerP
{
    public record GetMaxSalaryResponse(bool IsSuccess, long MaxSalary = -1);
}