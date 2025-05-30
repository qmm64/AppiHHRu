using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AppiHHRuInWinForms.Entities.Common.Responses.VacancyResponse
{
    public class ProfessionalRoles
    {
        [JsonPropertyName("id")]
        public string ProfessionalRolesId { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
