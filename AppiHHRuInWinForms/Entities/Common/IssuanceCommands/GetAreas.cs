using AppiHHRuInWinForms.Entities.Common.Responses.SalaryManagerP;
using AppiHHRuInWinForms.Entities.Common.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppiHHRuInWinForms.Entities.Common.Responses.AreaManagerP;

namespace AppiHHRuInWinForms.Entities.Common.IssuanceCommands
{
    internal class GetAreas : IssuanceCommands
    {
        public GetAreas(ExtraditionManager extraditionManager)
        {
            this.extraditionManager = extraditionManager;
        }
        public override string Description()
        {
            return "По территории";
        }

        public override async Task<List<string>> Execute()
        {
            var result = await ((AreaManager)extraditionManager).GetAnyAreas();
            if (result.IsSuccess)
            {
                return result.AreaResponse;
            }
            return null;
        }
    }
}
