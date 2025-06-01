using AppiHHRuInWinForms.Entities.Common.Responses;
using AppiHHRuInWinForms.Entities.Common.Responses.SalaryManagerP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppiHHRuInWinForms.Entities.Common.IssuanceCommands
{
    public class GetSalaries : IssuanceCommands
    {
        public GetSalaries(ExtraditionManager extraditionManager)
        {
            this.extraditionManager = extraditionManager;
        }
        public override string Description()
        {
            return "По зарплате";
        }

        public override async Task<List<string>> Execute()
        {
            var result = await ((SalaryManager)extraditionManager).GetAnySalaries();
            if (result.IsSuccess)
            {
                return result.Salaries;
            }
            return null;
        }
    }
}
