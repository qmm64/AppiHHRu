﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AppiHHRuInWinForms.Entities.Common.Responses.VacancyResponse
{
    public class WorkScheduleByDays
    {
        [JsonPropertyName("id")]
        public string WorkScheduleByDaysId { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
