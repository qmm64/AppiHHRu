using AppiHHru;
using AppiHHru.Entities.Common.SalaryManagerP;
using AppiHHru.Entities.Common.WorkScheduleManagerP;
using AppiHHRuInWinForms.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppiHHRuInWinForms.Entities.IssuanceCommands
{
    public class GetFiveOnTwoSchedule : IssuanceCommands
    {
        public virtual string Description()
        {
            return "Получение процента вакансий с графиков 5/2";
        }

        public virtual async Task<string> Execute(ExtraditionManager workScheduleManager)
        {
            var result = await ((WorkScheduleManager)workScheduleManager).GetAllDaySchedulePercent(WorkScheduleManager.WorkScheduleFormat.FiveOnTwo);
            if (result.IsSuccess)
            {
                return result.Percent.ToString();
            }
            return "";
        }
    }
}
