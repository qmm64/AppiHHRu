using AppiHHRuInWinForms.Entities.Common.Responses;
using AppiHHRuInWinForms.Entities.Common.Responses.SalaryManagerP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppiHHRuInWinForms.Entities.Common.IssuanceCommands
{
    public class GetMaxSalary : IssuanceCommands
    {
        public GetMaxSalary(ExtraditionManager extraditionManager) 
        {
            this.extraditionManager = extraditionManager;
        }
        public override string Description()
        {
            return "Получение максимальной зарплаты";
        }

        //public override async Task<string> Execute()
        //{
        //    var result = await ((SalaryManager)extraditionManager).MaxSalary();
        //    if (result.IsSuccess)
        //    {
        //        return result.MaxSalary.ToString();
        //    }
        //    return "";
        //}
    }
}
