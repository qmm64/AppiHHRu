using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AppiHHRuInWinForms.Entities.Common.Responses.VacancyResponse
{
    public class Snippet
    {
        [JsonPropertyName("requirement")]
        public string Requirement { get; set; }

        [JsonPropertyName("responsibility")]
        public string Responsibility { get; set; }
    }
}
