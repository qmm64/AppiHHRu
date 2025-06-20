using AppiHHRuInWinForms.Entities.Common.Responses.VacancyResponse;

namespace AppiHHRuInWinForms.Entities.Common.IssuanceCommands
{
    public record GetParametersResponse(bool IsSuccess, List<VacancyResponse> ParametersResponse = null);
}
