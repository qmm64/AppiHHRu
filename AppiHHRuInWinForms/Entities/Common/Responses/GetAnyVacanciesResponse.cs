using AppiHHRuInWinForms.Entities.Common;
using AppiHHRuInWinForms.Entities.Common.Responses.VacancyResponse;

namespace AppiHHRuInWinForms.Entities.Common.Responses;

public record GetAnyVacanciesResponse(bool IsSuccess, VacanciesResponse VacancyResponce = null);