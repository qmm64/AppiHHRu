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

    private const string HHAppiUrl = "https://api.hh.ru/";
    private HttpClient HHHttpClient;

    public HHRuHttpClient()
    {
        HHHttpClient = new HttpClient();
        HHHttpClient.DefaultRequestHeaders.UserAgent.ParseAdd("HHVacFinder");
        HHHttpClient.Timeout = TimeSpan.FromSeconds(10);
    }
    public async Task<GetAnyVacanciesResponse> GetAnyVacancies() 
    {
        try
        {
            var result = await HHHttpClient.GetAsync(HHAppiUrl+ "vacancies");
            var responce = await result.Content.ReadAsStringAsync();
            var vacancyResponse = JsonSerializer.Deserialize<VacancyResponse>(responce);
            if (vacancyResponse == null)
            {
                Console.WriteLine("Не удалось распарсить вакансии!");
                return new GetAnyVacanciesResponse(false);
            }
            return new GetAnyVacanciesResponse(true,vacancyResponse);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Произошла ошибка при выполнении {nameof(GetAnyVacancies)}. Текст исключение: {ex.Message}");
            return new GetAnyVacanciesResponse(false);
        }
    }
}
