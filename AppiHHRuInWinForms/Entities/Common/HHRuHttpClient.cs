using AppiHHRuInWinForms.Entities.Common.Responses;
using AppiHHRuInWinForms.Entities.Common.Responses.VacancyResponse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace AppiHHRuInWinForms.Entities.Common;

public class HHRuHttpClient
{

    private const string HHAppiUrl = "https://api.hh.ru/vacancies?";
    private HttpClient HHHttpClient;
    private int countOfPages = 1;

    public HHRuHttpClient()
    {
        HHHttpClient = new HttpClient();
        HHHttpClient.DefaultRequestHeaders.UserAgent.ParseAdd("HHVacFinder");
        HHHttpClient.Timeout = TimeSpan.FromSeconds(10);
    }
    public async Task<GetAnyVacanciesResponse> GetAnyVacancies(bool dependsOnSalary = false) 
    {
        try
        {
            var vacancies = new List<Vacancy>();
            for (int i = 0; i < countOfPages; i++)
            {
                var result = await HHHttpClient.GetAsync(HHAppiUrl + $"page={i}&only_with_salary={dependsOnSalary}");
                var responce = await result.Content.ReadAsStringAsync();
                vacancies.AddRange(JsonSerializer.Deserialize<VacanciesResponse>(responce).Vacancies);
                if (vacancies == null)
                {
                    Console.WriteLine("Не удалось распарсить вакансии!");
                    return new GetAnyVacanciesResponse(false);
                }
            }
            Task.WhenAll();
            return new GetAnyVacanciesResponse(true,vacancies);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Произошла ошибка при выполнении {nameof(GetAnyVacancies)}. Текст исключение: {ex.Message}");
            return new GetAnyVacanciesResponse(false);
        }
    }

    public void SetCountOfPages(int countOfPages)
    {
        this.countOfPages = countOfPages;
    }

    public int GetCountOfPages()
    {
        return countOfPages;
    }
}
