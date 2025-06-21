using AppiHHRuInWinForms.Entities.Common.Responses;
using AppiHHRuInWinForms.Entities.Common.Responses.VacancyResponse;

namespace AppiHHRuInWinForms.Entities.Common.IssuanceCommands
{
    public interface ICommandsWithHardFind 
    {
        public GetParametersResponse GetParameters(GetAnyVacanciesResponse getAnyVacanciesResponse);
        public string ModificationOfURL(VacancyResponse vacancyResponse);
    }
}
