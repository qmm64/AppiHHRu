using System.Text.Json.Serialization;

namespace AppiHHRuInWinForms.Entities.Common.Responses.VacancyResponse
{
    public class VacancyResponse
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
