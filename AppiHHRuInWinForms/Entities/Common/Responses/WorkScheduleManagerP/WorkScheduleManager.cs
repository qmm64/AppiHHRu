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
            Console.WriteLine("Не удалось распарсить вакансии");
            return new GetAllDaySchedulePercentResponce(false);
        }
        List<string> daySchedules = new();
        foreach(var format in WorkScheduleFormats.Keys)
        {
            var countAllDaySchefule = responce.Vacancies.Count(vacancy => vacancy.WorkingHoursByDays.Any(e => e.WorkScheduleByDaysId == format));
            double allDayPercent = (double)countAllDaySchefule / (double)responce.Vacancies.Count * 100;
            daySchedules.Add($"График {WorkScheduleFormats[format]} - {countAllDaySchefule}, процент от общего числа: {allDayPercent}");
        }
        return new GetAllDaySchedulePercentResponce(true, daySchedules);
    }

    public enum WorkScheduleFormat
    {
        FiveOnTwo,
        TwoOnTwo,
        SixOnOne,
        FourOnThree,
        ThreeOnTwo,
    }

    private string ConvertWorkScheduleFormatToString(WorkScheduleFormat workScheduleFormat)
    {
        switch (workScheduleFormat)
        {
            case WorkScheduleFormat.FiveOnTwo:
                return "FIVE_ON_TWO_OFF";
            case WorkScheduleFormat.TwoOnTwo:
                return "TWO_ON_TWO_OFF";
            case WorkScheduleFormat.SixOnOne:
                return "SIX_ON_ONE_OFF";
            case WorkScheduleFormat.FourOnThree:
                return "FOUR_ON_THREE_OFF";
            case WorkScheduleFormat.ThreeOnTwo:
                return "THREE_ON_TWO_OFF";
        }
        return "";
    }
}
