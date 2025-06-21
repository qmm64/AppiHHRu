using AppiHHRuInWinForms.Entities.Common.Responses;
using AppiHHRuInWinForms.Entities.Common.Responses.VacancyResponse;

namespace AppiHHRuInWinForms.Entities.Common.Managers;

public class SalaryManager:ExtraditionManager
{
    public SalaryManager(HHRuHttpClient hHRuHttpClient) : base(hHRuHttpClient)
    {
    }

    private List<int> GetSalaries(List<Vacancy> Vacancies)
    {

        var salary = new List<int>();

        foreach (var vacancy in Vacancies)
        {
            if (vacancy?.SalaryRange?.Mode?.Id == "MONTH")
            {
                if (vacancy.SalaryRange.From.HasValue)
                {
                    salary.Add(vacancy.SalaryRange.From.Value);
                }
            }
        }
        return salary;
    }

    private string MaxSalary(List<int> salaries)
    {
        try
        {
            return salaries.Max().ToString();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Ошибка расчёта максимальной зарплаты: {ex.Message}");
            return "Ошибка расчёта";
        }
    } 

    private string MinSalary(List<int> salaries)
    {
        try
        {

            return salaries.Min().ToString();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Ошибка расчёта минимальной зарплаты: {ex.Message}");
            return "Ошибка расчёта";
        }
    }

    private string ArrangeSalary(List<int> salaries)
    {
        try
        {
            return (salaries.Sum()/(float)salaries.Count).ToString();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Ошибка расчёта средней зарплаты: {ex.Message}");
            return "Ошибка расчёта";
        }
    }

    private string MedianSalary(List<int> salaries)
    {
        try
        {
            salaries.Sort();
            if (salaries.Count % 2 != 0)
            {
                return salaries[salaries.Count/2+1].ToString();
            }
            else
            {
                return ((salaries[salaries.Count / 2 + 1] + salaries[salaries.Count / 2])/2).ToString();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Ошибка расчёта средней зарплаты: {ex.Message}");
            return "Ошибка расчёта";
        }
    }

    public virtual async Task<GetManagersResponse> GetResponse()
    {
        try
        {
            var response = await _httpClient.GetAnyVacancies(true);
            if (!response.IsSuccess)
            {
                MessageBox.Show("Не удалось рассчитать среднюю зарплату");
                return new GetManagersResponse(false);
            }
            var salaries = GetSalaries(response.Vacancies);
            List<string> salariesList = new List<string>();
            salariesList.Add($"Максимальная зарплата: {MaxSalary(salaries)} руб/месяц");
            salariesList.Add($"Минимальная зарплата: {MinSalary(salaries)} руб/месяц");
            salariesList.Add($"Средняя зарплата: {ArrangeSalary(salaries)} руб/месяц");
            salariesList.Add($"Медианная зарплата: {MedianSalary(salaries)} руб/месяц");
            return new GetManagersResponse(true, salariesList);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Ошибка расчёта зарплат: {ex.Message}");
            return new GetManagersResponse(false);
        }
    }
}
