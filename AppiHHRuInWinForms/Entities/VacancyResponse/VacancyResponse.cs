using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AppiHHru
{
    public class VacancyResponse
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
