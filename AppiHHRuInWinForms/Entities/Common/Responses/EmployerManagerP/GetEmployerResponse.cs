using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppiHHRuInWinForms.Entities.Common.Responses.EmployerManagerP
{
    public record GetEmployerResponse(bool IsSuccess, List<string> EmployerResponse = null);
}
