using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppiHHRuInWinForms.Entities.Common.Responses
{
    public record GetManagersResponse(bool IsSuccess, List<string> Response = null);
}
