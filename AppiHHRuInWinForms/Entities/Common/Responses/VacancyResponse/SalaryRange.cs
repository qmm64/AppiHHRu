using System.Text.Json.Serialization;

namespace AppiHHRuInWinForms.Entities.Common.Responses.VacancyResponse
{
    public class SalaryRange
    {
        [JsonPropertyName("from")]
        public int? From { get; set; }

        [JsonPropertyName("to")]
        public int? To { get; set; }

        [JsonPropertyName("currency")]
        public string Currency { get; set; }

        [JsonPropertyName("mode")]
        public VacancyResponse Mode { get; set; }
    }
}