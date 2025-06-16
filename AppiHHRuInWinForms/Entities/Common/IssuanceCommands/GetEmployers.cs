using AppiHHRuInWinForms.Entities.Common.Responses;
using AppiHHRuInWinForms.Entities.Common.Responses.AreaManagerP;
using AppiHHRuInWinForms.Entities.Common.Responses.EmployerManagerP;
using AppiHHRuInWinForms.Entities.Common.Responses.VacancyResponse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppiHHRuInWinForms.Entities.Common.IssuanceCommands
{
    internal class GetEmployers : IssuanceCommands
    {
        public GetEmployers(ExtraditionManager extraditionManager)
        {
            this.extraditionManager = extraditionManager;
        }

        public override string Description()
        {
            return "По работадателю";
        }

        public override async Task<List<string>> Execute()
        {
            var result = await ((EmployerManager)extraditionManager).GetAnyEmployers();
            if (result.IsSuccess)
            {
                return result.EmployerResponse;
            }
            return null;
        }
    }
}
