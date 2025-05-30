using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppiHHRuInWinForms.Entities.Common.Responses.AreaManagerP
{
    public record GetAreaResponse(bool IsSuccess, List<string> AreaResponse = null);
}
