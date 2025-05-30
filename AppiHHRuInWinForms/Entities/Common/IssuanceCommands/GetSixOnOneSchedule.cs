using AppiHHRuInWinForms.Entities.Common.Responses;
using AppiHHRuInWinForms.Entities.Common.Responses.WorkScheduleManagerP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppiHHRuInWinForms.Entities.Common.IssuanceCommands
{
    public class GetSixOnOneSchedule : IssuanceCommands
    {
        public GetSixOnOneSchedule(ExtraditionManager extraditionManager) 
        {
            this.extraditionManager = extraditionManager;
        }
        public override string Description()
        {
            return "Получение процента вакансий с графиков 2/2";
        }

        //public override async Task<string> Execute()
        //{
        //    var result = await ((WorkScheduleManager)extraditionManager).GetAllDaySchedulePercent(WorkScheduleManager.WorkScheduleFormat.SixOnOne);
        //    if (result.IsSuccess)
        //    {
        //        return result.Percent.ToString();
        //    }
        //    return "";
        //}
    }
}
