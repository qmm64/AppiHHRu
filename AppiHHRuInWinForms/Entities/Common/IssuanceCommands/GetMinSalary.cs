using AppiHHRuInWinForms.Entities.Common.Responses;
using AppiHHRuInWinForms.Entities.Common.Responses.SalaryManagerP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppiHHRuInWinForms.Entities.Common.IssuanceCommands
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

        //public override async Task<string> Execute()
        //{
        //    var result = await ((SalaryManager)extraditionManager).MinSalary();
        //    if (result.IsSuccess)
        //    {
        //        return result.MinSalary.ToString();
        //    }
        //    return "";
        //}
    }
}
