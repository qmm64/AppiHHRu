using AppiHHRuInWinForms.Entities.Common.Managers;
using AppiHHRuInWinForms.Entities.Common.Responses;
using AppiHHRuInWinForms.Entities.Common.Responses.VacancyResponse;

namespace AppiHHRuInWinForms.Entities.Common.IssuanceCommands
{
    internal class GetAreas : IssuanceCommands, ICommandsWithHardFind
    {
        public GetAreas(ExtraditionManager extraditionManager)
        {
            this.extraditionManager = extraditionManager;
        }

        public override string Description()
        {
            return "По территории";
        }

        public override async Task<List<string>> Execute()
        {
            var result = await ((AreaManager)extraditionManager).GetResponse();
            if (result.IsSuccess)
            {
                return result.Response;
            }
            return null;
        }

        public GetParametersResponse GetParameters(GetAnyVacanciesResponse getAnyVacanciesResponse)
        {
            try
            {
                Dictionary<string, VacancyResponse> uniqueAreas = new();
                foreach (var vacancy in getAnyVacanciesResponse.Vacancies)
                {
                    if (!uniqueAreas.ContainsKey(vacancy.Area.Id))
                    {
                        uniqueAreas[vacancy.Area.Id] = vacancy.Area;
                    }
                }
                return new GetParametersResponse(true, uniqueAreas.Values.ToList());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка получения параметров. Текст: {ex.Message}");
                return new GetParametersResponse(false);
            }
        }

        public string ModificationOfURL(VacancyResponse vacancyResponse)
        {
            return $"area={vacancyResponse.Id}";
        }
    }
}
