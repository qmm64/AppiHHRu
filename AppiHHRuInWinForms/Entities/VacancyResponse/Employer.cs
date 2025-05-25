using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AppiHHru
{
    public class Employer
    {
        [JsonPropertyName("id")]
        public string EmployerId { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
