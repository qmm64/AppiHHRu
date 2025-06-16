using AppiHHRuInWinForms.Entities.Common.Responses;
using AppiHHRuInWinForms.Entities.Common.Responses.VacancyResponse;
using AppiHHRuInWinForms.Entities.Common.Responses.WorkScheduleManagerP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppiHHRuInWinForms.Entities.Common.IssuanceCommands
{
    public class GetWorkDaySchedules : IssuanceCommands, ICommandsWithHardFind
    {
        public GetWorkDaySchedules(ExtraditionManager extraditionManager)
        {
            this.extraditionManager = extraditionManager;
        }

        public string AppendToURL()
        {
            throw new NotImplementedException();
        }

        public override string Description()
        {
            return "По графику работы";
        }

        public override async Task<List<string>> Execute()
        {
            var result = await ((WorkScheduleManager)extraditionManager).GetAllDaySchedulePercent();
            if (result.IsSuccess)
            {
                return result.WorkSchedules;
            }
            return null;
        }

        public List<VacancyResponse> GetParametrs(GetAnyVacanciesResponse getAnyVacanciesResponse)
        {
            Dictionary<string, VacancyResponse> uniqueWorkDaySchedules = new();
            foreach (var vacancy in getAnyVacanciesResponse.Vacancies)
            {
                foreach (var format in vacancy.WorkingHoursByDays)
                {
                    if (!uniqueWorkDaySchedules.ContainsKey(format.Id)/* && format.Name.Length==3*/)
                    {
                        uniqueWorkDaySchedules[format.Id] = format;
                    }
                }
            }
            return uniqueWorkDaySchedules.Values.ToList();
        }

        public string ModificationOfURL(VacancyResponse vacancyResponse)
        {
            return $"work_schedule_by_days={vacancyResponse.Id}&area=113";
        }
    }
}
