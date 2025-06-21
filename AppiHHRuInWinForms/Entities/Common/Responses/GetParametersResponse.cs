

namespace AppiHHRuInWinForms.Entities.Common.Responses
{
    public record GetParametersResponse(bool IsSuccess, List<VacancyResponse.VacancyResponse> ParametersResponse = null);
}
