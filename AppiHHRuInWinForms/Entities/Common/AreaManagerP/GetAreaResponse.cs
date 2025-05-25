using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppiHHRuInWinForms.Entities.Common.AreaManagerP
{
    public record GetAreaResponse(bool IsSuccess, float ArrangeSalary = -1);
}
