
using AppiHHRuInWinForms.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppiHHru.Entities.Common.WorkScheduleManagerP;

internal class WorkScheduleManager : ExtraditionManager
{
    public WorkScheduleManager(HHRuHttpClient hHRuHttpClient) : base(hHRuHttpClient)
    {
    }

    public async Task<GetAllDaySchedulePercentResponce> GetAllDaySchedulePercent(WorkScheduleFormat workScheduleFormat)
    {
        var responce = await _httpClient.GetAnyVacancies();
        if (!responce.IsSuccess)
        {
            Console.WriteLine("Не удалось распарсить вакансии");
            return new GetAllDaySchedulePercentResponce(false);
        }
        var countAllDaySchefule = responce.VacancyResponce.Vacancies.Count(vacancy => vacancy.WorkingHoursByDays.Any(e => e.WorkScheduleByDaysId == ConvertWorkScheduleFormatToString(workScheduleFormat)));
        double allDayPercent = (double)countAllDaySchefule / (double)responce.VacancyResponce.Vacancies.Length * 100;
        return new GetAllDaySchedulePercentResponce(true, allDayPercent);
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
