using AppiHHru.Entities.Common.WorkScheduleManagerP;
using AppiHHRuInWinForms.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppiHHRuInWinForms.Entities.IssuanceCommands
{
    internal class GetFourOnThreeSchedule : IssuanceCommands
    {
        public virtual string Description()
        {
            return "Получение процента вакансий с графиков 4/3";
        }

        public virtual async Task<string> Execute(ExtraditionManager workScheduleManager)
        {
            var result = await ((WorkScheduleManager)workScheduleManager).GetAllDaySchedulePercent(WorkScheduleManager.WorkScheduleFormat.FourOnThree);
            if (result.IsSuccess)
            {
                return result.Percent.ToString();
            }
            return "";
        }
    }
}
