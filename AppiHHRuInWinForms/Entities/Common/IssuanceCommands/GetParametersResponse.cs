using AppiHHRuInWinForms.Entities.Common.Responses.VacancyResponse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppiHHRuInWinForms.Entities.Common.IssuanceCommands
{
    public record GetParametersResponse(bool IsSuccess, List<VacancyResponse> ParametersResponse = null);
}
