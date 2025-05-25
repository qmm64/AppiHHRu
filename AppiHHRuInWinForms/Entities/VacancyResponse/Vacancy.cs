using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AppiHHru
{
    public class Vacancy
    {
        [JsonPropertyName("id")]
        public string VacancyId { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("department")]
        public Department Department { get; set; }

        [JsonPropertyName("area")]
        public Area Area { get; set; }

        [JsonPropertyName("salary_range")]
        public SalaryRange SalaryRange { get; set; }

        [JsonPropertyName("type")]
        public VacancyType VacancyType { get; set; }

        [JsonPropertyName("published_at")]
        public string PublishedAt { get; set; }

        [JsonPropertyName("employer")]
        public Employer Employer { get; set; }

        [JsonPropertyName("snippet")]
        public Snippet Snippet { get; set; }

        [JsonPropertyName("work_format")]
        public WorkFormat[] WorkFormat { get; set; }

        [JsonPropertyName("working_hours")]
        public WorkingHours[] WorkingHours { get; set; }

        [JsonPropertyName("work_schedule_by_days")]
        public WorkScheduleByDays[] WorkingHoursByDays { get; set; }

        [JsonPropertyName("professional_roles")]
        public ProfessionalRoles[] ProfessionalRoles { get; set; }

        [JsonPropertyName("experience")]
        public Experience Experience { get; set; }

        [JsonPropertyName("employment")]
        public Employment Employment { get; set; }
    }
}
