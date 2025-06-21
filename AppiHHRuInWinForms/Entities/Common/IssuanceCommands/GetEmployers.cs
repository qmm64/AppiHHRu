using AppiHHRuInWinForms.Entities.Common.Managers;

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
            var result = await ((EmployerManager)extraditionManager).GetResponse();
            if (result.IsSuccess)
            {
                return result.Response;
            }
            return null;
        }
    }
}
