using AppiHHRuInWinForms.Entities.Common.Responses;

namespace AppiHHRuInWinForms.Entities.Common.Managers;

internal class WorkScheduleManager : ExtraditionManager
{
    public WorkScheduleManager(HHRuHttpClient hHRuHttpClient) : base(hHRuHttpClient)
    {
    }

    private Dictionary<string, string> WorkScheduleFormats = new Dictionary<string, string>{
        { "FIVE_ON_TWO_OFF","5/2"},
        { "TWO_ON_TWO_OFF","2/2"},
        { "SIX_ON_ONE_OFF","6/1"},
        { "FOUR_ON_THREE_OFF","4/3"},
        { "THREE_ON_TWO_OFF","3/2"},
        { "WEEKEND","По выходным"},
        { "FLEXIBLE","Гибкий" },
        { "OTHER","Другое" }
    };

    public virtual async Task<GetManagersResponse> GetResponse()
    {
        var responce = await _httpClient.GetAnyVacancies();
        if (!responce.IsSuccess)
        {
            MessageBox.Show("Не удалось распарсить вакансии");
            return new GetManagersResponse(false);
        }
        List<string> daySchedules = new();
        foreach (var format in WorkScheduleFormats.Keys)
        {
            var countAllDaySchefule = responce.Vacancies.Count(vacancy => vacancy.WorkingHoursByDays.Any(e => e.Id == format));
            double allDayPercent = Math.Round(countAllDaySchefule / (double)responce.Vacancies.Count * 100, 2);
            daySchedules.Add($"График {WorkScheduleFormats[format]} - {countAllDaySchefule} вакансий, процент от общего числа: {allDayPercent}");
        }
        return new GetManagersResponse(true, daySchedules);
    }
}
