using AppiHHRuInWinForms.Entities.Common;

namespace AppiHHru;

public record GetAnyVacanciesResponse(bool IsSuccess, VacancyResponse VacancyResponce = null);