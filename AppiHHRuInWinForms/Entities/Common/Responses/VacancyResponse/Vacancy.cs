using System.Text.Json.Serialization;

namespace AppiHHRuInWinForms.Entities.Common.Responses.VacancyResponse
{
    public class Vacancy : VacancyResponse
    {
        [JsonPropertyName("department")]
        public VacancyResponse Department { get; set; }

        [JsonPropertyName("area")]
        public VacancyResponse Area { get; set; }

        [JsonPropertyName("salary_range")]
        public SalaryRange SalaryRange { get; set; }

        [JsonPropertyName("type")]
        public VacancyResponse VacancyType { get; set; }

        [JsonPropertyName("published_at")]
        public string PublishedAt { get; set; }

        [JsonPropertyName("employer")]
        public VacancyResponse Employer { get; set; }

        [JsonPropertyName("snippet")]
        public VacancyResponse Snippet { get; set; }

        [JsonPropertyName("work_format")]
        public VacancyResponse[] WorkFormat { get; set; }

        [JsonPropertyName("working_hours")]
        public VacancyResponse[] WorkingHours { get; set; }

        [JsonPropertyName("work_schedule_by_days")]
        public VacancyResponse[] WorkingHoursByDays { get; set; }

        [JsonPropertyName("professional_roles")]
        public VacancyResponse[] ProfessionalRoles { get; set; }

        [JsonPropertyName("experience")]
        public VacancyResponse Experience { get; set; }

        [JsonPropertyName("employment")]
        public VacancyResponse Employment { get; set; }
    }
}
