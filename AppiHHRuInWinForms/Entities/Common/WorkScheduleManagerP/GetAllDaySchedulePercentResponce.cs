using AppiHHRuInWinForms;
using AppiHHRuInWinForms.Entities.Common;

namespace AppiHHru.Entities.Common.WorkScheduleManagerP
{
    public record GetAllDaySchedulePercentResponce(bool IsSuccess, double Percent = -1);
}