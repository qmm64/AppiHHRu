using AppiHHRuInWinForms;
using AppiHHRuInWinForms.Entities.Common;

namespace AppiHHru.Entities.Common.SalaryManagerP
{
    public record GetMaxSalaryResponse(bool IsSuccess, long MaxSalary = -1);
}