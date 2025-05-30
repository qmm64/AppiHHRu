using AppiHHru.Entities.Common.SalaryManagerP;
using AppiHHRuInWinForms.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppiHHRuInWinForms.Entities.IssuanceCommands
{
    public class GetMinSalary : IssuanceCommands
    {
        public GetMinSalary(ExtraditionManager extraditionManager) 
        {
            this.extraditionManager = extraditionManager;
        }
        public override string Description()
        {
            return "Получение минимальной зарплаты";
        }

        public override async Task<string> Execute()
        {
            var result = await ((SalaryManager)extraditionManager).MinSalary();
            if (result.IsSuccess)
            {
                return result.MinSalary.ToString();
            }
            return "";
        }
    }
}
