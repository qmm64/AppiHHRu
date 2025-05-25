using AppiHHRuInWinForms;
using AppiHHRuInWinForms.Entities.Common;

namespace AppiHHru.Entities.Common.SalaryManagerP
{
    public record GetMinSalaryResponse(bool IsSuccess, long MinSalary = -1);
}