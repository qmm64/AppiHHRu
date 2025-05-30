using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppiHHRuInWinForms.Entities.Common.Responses
{
    public abstract class ExtraditionManager
    {
        protected HHRuHttpClient _httpClient;

        public ExtraditionManager(HHRuHttpClient hHRuHttpClient)
        {
            _httpClient = hHRuHttpClient;
        }
    }
}
