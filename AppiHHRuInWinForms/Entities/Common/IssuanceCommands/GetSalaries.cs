using AppiHHRuInWinForms.Entities.Common.Managers;
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
            var result = await ((SalaryManager)extraditionManager).GetResponse();
            if (result.IsSuccess)
            {
                return result.Response;
            }
            return null;
        }
    }
}
