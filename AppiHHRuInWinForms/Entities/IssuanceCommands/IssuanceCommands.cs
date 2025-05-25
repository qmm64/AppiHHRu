using AppiHHru.Entities.Common.SalaryManagerP;
using AppiHHRuInWinForms.Entities.Common;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppiHHRuInWinForms.Entities.IssuanceCommands
{
    public abstract class IssuanceCommands
    {
        public virtual string Description()
        {
            return "";
        }

        public virtual async Task<string> Execute(ExtraditionManager extraditionManager)
        {
            return "";
        }

        public override string ToString()
        {
            return Description();
        }
    }
}
