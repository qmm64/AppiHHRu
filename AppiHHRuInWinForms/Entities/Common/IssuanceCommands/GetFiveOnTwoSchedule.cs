using AppiHHru;
using AppiHHru.Entities.Common.SalaryManagerP;
using AppiHHRuInWinForms.Entities.Common.Responses;
using AppiHHRuInWinForms.Entities.Common.Responses.WorkScheduleManagerP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppiHHRuInWinForms.Entities.Common.IssuanceCommands
{
    public class GetFiveOnTwoSchedule : IssuanceCommands
    {
        public GetFiveOnTwoSchedule(ExtraditionManager extraditionManager) 
        {
            this.extraditionManager = extraditionManager;
        }
        public override string Description()
        {
            return "Получение процента вакансий с графиков 5/2";
        }

        public override async Task<string> Execute()
        {
            var result = await ((WorkScheduleManager)extraditionManager).GetAllDaySchedulePercent(WorkScheduleManager.WorkScheduleFormat.FiveOnTwo);
            if (result.IsSuccess)
            {
                return result.Percent.ToString();
            }
            return "";
        }
    }
}
