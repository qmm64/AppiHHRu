using AppiHHru.Entities.Common.SalaryManagerP;
using AppiHHRuInWinForms.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppiHHRuInWinForms.Entities.IssuanceCommands
{
    public class GetMaxSalary : IssuanceCommands
    {
        public override string Description()
        {
            return "Получение максимальной зарплаты";
        }

        public override async Task<string> Execute(ExtraditionManager salaryManager)
        {
            var result = await ((SalaryManager)salaryManager).MaxSalary();
            if (result.IsSuccess)
            {
                return result.MaxSalary.ToString();
            }
            return "";
        }
    }
}
