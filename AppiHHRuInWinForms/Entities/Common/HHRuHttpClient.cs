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
    private string ModificationOfURL = "&area=113";
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
            var tasks = new List<Task<Vacancy[]>>();
            for (int i = 0; i < countOfPages; i++)
            {
                tasks.Add(DeserializePage(dependsOnSalary, i));
            }
            var results = await Task.WhenAll(tasks);
            var vacancies = results.Where(x => x != null).SelectMany(x => x).ToList();
            return new GetAnyVacanciesResponse(true, vacancies);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Произошла ошибка при выполнении {nameof(GetAnyVacancies)}. Текст исключение: {ex.Message}");
            return new GetAnyVacanciesResponse(false);
        }
    }

    private async Task<Vacancy[]> DeserializePage(bool dependsOnSalary, int numberOfPage)
    {
        var URL = $"{HHAppiUrl}page={numberOfPage}&only_with_salary={dependsOnSalary}{ModificationOfURL}";
        var result = await HHHttpClient.GetAsync(URL);
        var responce = await result.Content.ReadAsStringAsync();
        return JsonSerializer.Deserialize<VacanciesResponse>(responce).Vacancies;
    }

    public void SetCountOfPages(int countOfPages)
    {
        this.countOfPages = countOfPages;
    }

    public int GetCountOfPages()
    {
        return countOfPages;
    }

    public void ModifyURL()
    {
        ModificationOfURL = "&area=113";
    }

    public void ModifyURL(string modification)
    {
        ModificationOfURL = $"&{modification}";
    }
}
