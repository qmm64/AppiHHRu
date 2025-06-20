using AppiHHRuInWinForms.Entities.Common.Responses.VacancyResponse;

namespace AppiHHRuInWinForms.Entities.Common.Responses;

public record GetAnyVacanciesResponse(bool IsSuccess, List<Vacancy> Vacancies = null);