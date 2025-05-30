using AppiHHRuInWinForms;
using AppiHHRuInWinForms.Entities.Common;

namespace AppiHHRuInWinForms.Entities.Common.Responses.SalaryManagerP
{
    public record GetArrangeResponse(bool IsSuccess, float ArrangeSalary = -1);
}