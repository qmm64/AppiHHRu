using System.Text.Json.Serialization;

namespace AppiHHRuInWinForms.Entities.Common.Responses.VacancyResponse
{
    public class VacanciesResponse
    {
        [JsonPropertyName("items")]
        public Vacancy[]? Vacancies {  get; set; }

        [JsonPropertyName("found")]
        public long CountVacancies { get; set; }

        [JsonPropertyName("pages")]
        public long CountPages { get; set; }

        [JsonPropertyName("page")]
        public long CurrentPage { get; set; }

        [JsonPropertyName("per_page")]
        public long VacancyPerPage { get; set; }
    }
}
