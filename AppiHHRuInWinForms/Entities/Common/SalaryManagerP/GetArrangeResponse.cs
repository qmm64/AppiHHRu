using AppiHHRuInWinForms;
using AppiHHRuInWinForms.Entities.Common;

namespace AppiHHru.Entities.Common.SalaryManagerP
{
    public record GetArrangeResponse(bool IsSuccess, float ArrangeSalary = -1);
}