using AppiHHRuInWinForms;
using AppiHHRuInWinForms.Entities.Common;

namespace AppiHHRuInWinForms.Entities.Common.Responses.WorkScheduleManagerP
{
    public record GetAllDaySchedulePercentResponce(bool IsSuccess, List<string> WorkSchedules = null);
}