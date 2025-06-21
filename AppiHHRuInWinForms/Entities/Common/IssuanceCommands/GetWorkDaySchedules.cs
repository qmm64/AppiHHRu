using AppiHHRuInWinForms.Entities.Common.Managers;
using AppiHHRuInWinForms.Entities.Common.Responses;
using AppiHHRuInWinForms.Entities.Common.Responses.VacancyResponse;

namespace AppiHHRuInWinForms.Entities.Common.IssuanceCommands
{
    public class GetWorkDaySchedules : IssuanceCommands, ICommandsWithHardFind
    {
        public GetWorkDaySchedules(ExtraditionManager extraditionManager)
        {
            this.extraditionManager = extraditionManager;
        }

        public override string Description()
        {
            return "По графику работы";
        }

        public override async Task<List<string>> Execute()
        {
            var result = await ((WorkScheduleManager)extraditionManager).GetResponse();
            if (result.IsSuccess)
            {
                return result.Response;
            }
            return null;
        }

        public GetParametersResponse GetParameters(GetAnyVacanciesResponse getAnyVacanciesResponse)
        {
            try
            {
                Dictionary<string, VacancyResponse> uniqueWorkDaySchedules = new();
                foreach (var vacancy in getAnyVacanciesResponse.Vacancies)
                {
                    foreach (var format in vacancy.WorkingHoursByDays)
                    {
                        if (!uniqueWorkDaySchedules.ContainsKey(format.Id))
                        {
                            uniqueWorkDaySchedules[format.Id] = format;
                        }
                    }
                }
                return new GetParametersResponse(true, uniqueWorkDaySchedules.Values.ToList());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка получения параметров. Текст: {ex.Message}");
                return new GetParametersResponse(false);
            }
        }

        public string ModificationOfURL(VacancyResponse vacancyResponse)
        {
            return $"work_schedule_by_days={vacancyResponse.Id}&area=113";
        }
    }
}
