using AppiHHRuInWinForms.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppiHHru.Entities.Common.SalaryManagerP;

public class SalaryManager:ExtraditionManager
{
    public SalaryManager(HHRuHttpClient hHRuHttpClient) : base(hHRuHttpClient)
    {
    }

    private List<long> GetSalaries(VacancyResponse vacancyResponse)
    {

        var salary = new List<long>();

        foreach (var vacancy in vacancyResponse.Vacancies)
        {
            if (vacancy?.SalaryRange?.Mode?.SalaryRangeModeId == "MONTH")
            {
                if (vacancy.SalaryRange.From.HasValue)
                {
                    salary.Add(vacancy.SalaryRange.From.Value);
                }
            }
        }
        return salary;
    }

    public async Task<GetMaxSalaryResponse> MaxSalary()
    {
        try
        {
            var response = await _httpClient.GetAnyVacancies();
            if (!response.IsSuccess)
            {
                Console.WriteLine("Не удалось рассчитать максимальную зарплату");
                return new GetMaxSalaryResponse(false);
            }

            var salary = GetSalaries(response.VacancyResponce);
            return new GetMaxSalaryResponse(true, salary.Max());
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка расчёта максимальной зарплаты: {ex.Message}");
            return new GetMaxSalaryResponse(false);
        }
    } 

    public async Task<GetMinSalaryResponse> MinSalary()
    {
        try
        {
            var response = await _httpClient.GetAnyVacancies();
            if (!response.IsSuccess)
            {
                Console.WriteLine("Не удалось рассчитать минимальную зарплату");
                return new GetMinSalaryResponse(false);
            }

            var salary = GetSalaries(response.VacancyResponce);
            return new GetMinSalaryResponse(true, salary.Min());
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка расчёта минимальной зарплаты: {ex.Message}");
            return new GetMinSalaryResponse(false);
        }
    }

    public async Task<GetArrangeResponse> ArrangeSalary()
    {
        try
        {
            var response = await _httpClient.GetAnyVacancies();
            if (!response.IsSuccess)
            {
                Console.WriteLine("Не удалось рассчитать среднюю зарплату");
                return new GetArrangeResponse(false);
            }

            var salary = GetSalaries(response.VacancyResponce);
            return new GetArrangeResponse(true, salary.Sum()/(float)salary.Count);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка расчёта средней зарплаты: {ex.Message}");
            return new GetArrangeResponse(false);
        }
    }
}
