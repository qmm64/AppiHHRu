using AppiHHRuInWinForms.Entities.Common.Responses;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppiHHRuInWinForms.Entities.Common.IssuanceCommands
{
    public abstract class IssuanceCommands
    {
        protected ExtraditionManager extraditionManager;
        public virtual string Description()
        {
            return "";
        }

        public virtual async Task<string> Execute()
        {
            return "";
        }

        public override string ToString()
        {
            return Description();
        }
    }
}
