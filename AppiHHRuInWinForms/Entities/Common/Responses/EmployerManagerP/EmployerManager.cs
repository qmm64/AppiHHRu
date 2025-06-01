using AppiHHRuInWinForms.Entities.Common.Responses.AreaManagerP;
using AppiHHRuInWinForms.Entities.Common.Responses.VacancyResponse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppiHHRuInWinForms.Entities.Common.Responses.EmployerManagerP
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

        public async Task<GetEmployerResponse> GetAnyEmployers()
        {
            var responce = await _httpClient.GetAnyVacancies();
            if (!responce.IsSuccess)
            {
                Console.WriteLine("Не удалось распарсить вакансии");
                return new GetEmployerResponse(false);
            }
            Dictionary<string, int> areas = GetEmployers(responce.Vacancies);
            List<string> areaResponse = new();
            foreach (var key in areas.Keys)
            {
                areaResponse.Add($"{key} - {areas[key].ToString()} вакансий, процент от общего числа: {(float)areas[key] / (float)responce.Vacancies.Count * 100}%");
            }
            return new GetEmployerResponse(true, areaResponse);
        }
    }
}
