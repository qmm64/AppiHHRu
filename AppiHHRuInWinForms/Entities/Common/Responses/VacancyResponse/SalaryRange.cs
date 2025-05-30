using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

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
        public SalaryRangeMode Mode { get; set; }
    }
}
