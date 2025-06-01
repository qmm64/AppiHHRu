using AppiHHRuInWinForms.Entities.Common.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AppiHHRuInWinForms.Entities.Common.Responses.WorkScheduleManagerP.WorkScheduleManager;

namespace AppiHHRuInWinForms.Entities.Common.Responses.WorkScheduleManagerP;

internal class WorkScheduleManager : ExtraditionManager
{
    public WorkScheduleManager(HHRuHttpClient hHRuHttpClient) : base(hHRuHttpClient)
    {
    }

    private Dictionary<string, string> WorkScheduleFormats = new Dictionary<string, string>{
        { "FIVE_ON_TWO_OFF","5 через 2"},
        { "TWO_ON_TWO_OFF","2 через 2"},
        { "SIX_ON_ONE_OFF","6 через 1"},
        { "FOUR_ON_THREE_OFF","4 через 3"},
        { "THREE_ON_TWO_OFF","3 через 2"},
    };

    public async Task<GetAllDaySchedulePercentResponce> GetAllDaySchedulePercent()
    {
        var responce = await _httpClient.GetAnyVacancies();
        if (!responce.IsSuccess)
        {
            MessageBox.Show("Не удалось распарсить вакансии");
            return new GetAllDaySchedulePercentResponce(false);
        }
        List<string> daySchedules = new();
        foreach(var format in WorkScheduleFormats.Keys)
        {
            var countAllDaySchefule = responce.Vacancies.Count(vacancy => vacancy.WorkingHoursByDays.Any(e => e.WorkScheduleByDaysId == format));
            double allDayPercent = (double)countAllDaySchefule / (double)responce.Vacancies.Count * 100;
            daySchedules.Add($"График {WorkScheduleFormats[format]} - {countAllDaySchefule} вакансий, процент от общего числа: {allDayPercent}");
        }
        return new GetAllDaySchedulePercentResponce(true, daySchedules);
    }
}
