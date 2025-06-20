using AppiHHRuInWinForms.Entities.Common.Responses.VacancyResponse;

namespace AppiHHRuInWinForms.Entities.Common.Responses.AreaManagerP
{
    internal class AreaManager : ExtraditionManager
    {
        public AreaManager(HHRuHttpClient hHRuHttpClient) : base(hHRuHttpClient)
        {
        }

        private Dictionary<string,int> GetTypesOfArea(List<Vacancy> vacancies) 
        {
            Dictionary<string,int> areas = new Dictionary<string,int>();
            foreach (var vacancy in vacancies)
            {
                if (areas.Keys.Any(n => n == vacancy.Area.Name))
                {
                    areas[vacancy.Area.Name]++;
                }
                else
                {
                    areas.Add(vacancy.Area.Name, 1);
                }
            }
            return areas;
        }

        public async Task<GetAreaResponse> GetAnyAreas()
        {
            var responce = await _httpClient.GetAnyVacancies();
            if (!responce.IsSuccess)
            {
                MessageBox.Show("Не удалось распарсить вакансии");
                return new GetAreaResponse(false);
            }
            Dictionary<string, int> areas = GetTypesOfArea(responce.Vacancies);
            List<string> areaResponse = new();
            foreach (var key in areas.Keys)
            {
                var procent = Math.Round((float)areas[key] / (float)responce.Vacancies.Count * 100,2);
                areaResponse.Add($"{key} - {areas[key].ToString()} вакансий, процент от общего числа: {procent}%");
            }
            return new GetAreaResponse(true, areaResponse);
        }
    }
}
