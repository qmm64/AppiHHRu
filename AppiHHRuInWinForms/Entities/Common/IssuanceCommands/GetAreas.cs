using AppiHHRuInWinForms.Entities.Common.Responses.SalaryManagerP;
using AppiHHRuInWinForms.Entities.Common.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppiHHRuInWinForms.Entities.Common.Responses.AreaManagerP;
using AppiHHRuInWinForms.Entities.Common.Responses.VacancyResponse;

namespace AppiHHRuInWinForms.Entities.Common.IssuanceCommands
{
    internal class GetAreas : IssuanceCommands, ICommandsWithHardFind
    {
        public GetAreas(ExtraditionManager extraditionManager)
        {
            this.extraditionManager = extraditionManager;
        }

        public string AppendToURL()
        {
            throw new NotImplementedException();
        }

        public override string Description()
        {
            return "По территории";
        }

        public override async Task<List<string>> Execute()
        {
            var result = await ((AreaManager)extraditionManager).GetAnyAreas();
            if (result.IsSuccess)
            {
                return result.AreaResponse;
            }
            return null;
        }

        public List<VacancyResponse> GetParametrs(GetAnyVacanciesResponse getAnyVacanciesResponse)
        {
            Dictionary<string, VacancyResponse> uniqueAreas = new();
            foreach (var vacancy in getAnyVacanciesResponse.Vacancies)
            {
                if (!uniqueAreas.ContainsKey(vacancy.Area.Id))
                {
                    uniqueAreas[vacancy.Area.Id] = vacancy.Area;
                }
            }
            return uniqueAreas.Values.ToList();
        }
    }
}
