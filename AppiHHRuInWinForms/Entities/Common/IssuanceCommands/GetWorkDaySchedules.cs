using AppiHHRuInWinForms.Entities.Common.Responses;
using AppiHHRuInWinForms.Entities.Common.Responses.WorkScheduleManagerP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppiHHRuInWinForms.Entities.Common.IssuanceCommands
{
    public class GetWorkDaySchedules : IssuanceCommands
    {
        public GetWorkDaySchedules(ExtraditionManager extraditionManager)
        {
            this.extraditionManager = extraditionManager;
        }

        public override string Description()
        {
            return "По графику работы";
        }

        public override async Task<List<string>> Execute()
        {
            var result = await ((WorkScheduleManager)extraditionManager).GetAllDaySchedulePercent();
            if (result.IsSuccess)
            {
                return result.WorkSchedules;
            }
            return null;
        }
    }
}
