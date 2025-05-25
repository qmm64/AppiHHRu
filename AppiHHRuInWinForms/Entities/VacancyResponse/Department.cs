using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AppiHHru
{
    public class Department
    {
        [JsonPropertyName("id")]
        public string DepartmentId { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
