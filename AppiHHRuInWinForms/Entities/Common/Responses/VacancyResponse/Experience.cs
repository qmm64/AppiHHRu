using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AppiHHRuInWinForms.Entities.Common.Responses.VacancyResponse
{
    public class Experience
    {
        [JsonPropertyName("id")]
        public string ExperienceId { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
