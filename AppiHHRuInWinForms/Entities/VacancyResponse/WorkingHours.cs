using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AppiHHru
{
    public class WorkingHours
    {
        [JsonPropertyName("id")]
        public string WorkingHourstId { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
