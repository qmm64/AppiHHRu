using AppiHHRuInWinForms.Entities.Common.Responses;
using AppiHHRuInWinForms.Entities.Common.Responses.VacancyResponse;

namespace AppiHHRuInWinForms.Entities.Common.Managers
{
    internal class EmployerManager : ExtraditionManager
    {
        public EmployerManager(HHRuHttpClient hHRuHttpClient) : base(hHRuHttpClient)
        {
        }

        private Dictionary<string, int> GetEmployers(List<Vacancy> vacancies)
        {
            Dictionary<string, int> employers = new Dictionary<string, int>();
            foreach (var vacancy in vacancies)
            {
                if (employers.Keys.Any(n => n == vacancy.Employer.Name))
                {
                    employers[vacancy.Employer.Name]++;
                }
                else
                {
                    employers.Add(vacancy.Employer.Name, 1);
                }
            }
            return employers;
        }

        public virtual async Task<GetManagersResponse> GetResponse()
        {
            var responce = await _httpClient.GetAnyVacancies();
            if (!responce.IsSuccess)
            {
                MessageBox.Show("Не удалось распарсить вакансии");
                return new GetManagersResponse(false);
            }
            Dictionary<string, int> areas = GetEmployers(responce.Vacancies);
            List<string> areaResponse = new();
            foreach (var key in areas.Keys)
            {
                var procent = Math.Round(areas[key] / (float)responce.Vacancies.Count * 100, 2);
                areaResponse.Add($"{key} - {areas[key].ToString()} вакансий, процент от общего числа: {procent}%");
            }
            return new GetManagersResponse(true, areaResponse);
        }
    }
}
