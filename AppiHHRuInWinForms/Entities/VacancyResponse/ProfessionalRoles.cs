using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AppiHHru
{
    public class ProfessionalRoles
    {
        [JsonPropertyName("id")]
        public string ProfessionalRolesId { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
