using AppiHHru.Entities.Common.SalaryManagerP;
using AppiHHRuInWinForms.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppiHHRuInWinForms.Entities.IssuanceCommands
{
    internal class GetArrangeSalary : IssuanceCommands
    {
        public override string Description()
        {
            return "Получение средней зарплаты";
        }

        public override async Task<string> Execute(ExtraditionManager salaryManager)
        {
            var result = await ((SalaryManager)salaryManager).ArrangeSalary();
            if (result.IsSuccess)
            {
                return result.ArrangeSalary.ToString();
            }
            return "";
        }
    }
}
