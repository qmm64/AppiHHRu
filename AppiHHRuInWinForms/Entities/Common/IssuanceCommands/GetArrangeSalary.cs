using AppiHHRuInWinForms.Entities.Common.Responses;
using AppiHHRuInWinForms.Entities.Common.Responses.SalaryManagerP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppiHHRuInWinForms.Entities.Common.IssuanceCommands
{
    internal class GetArrangeSalary : IssuanceCommands
    {
        public GetArrangeSalary(ExtraditionManager extraditionManager) 
        {
            this.extraditionManager = extraditionManager;
        }
        public override string Description()
        {
            return "Получение средней зарплаты";
        }

        public override async Task<string> Execute()
        {
            var result = await ((SalaryManager)extraditionManager).ArrangeSalary();
            if (result.IsSuccess)
            {
                return result.ArrangeSalary.ToString();
            }
            return "";
        }
    }
}
