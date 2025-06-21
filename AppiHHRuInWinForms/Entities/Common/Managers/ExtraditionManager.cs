using AppiHHRuInWinForms.Entities.Common.Responses;

namespace AppiHHRuInWinForms.Entities.Common.Managers
{
    public abstract class ExtraditionManager
    {
        protected HHRuHttpClient _httpClient;

        public ExtraditionManager(HHRuHttpClient hHRuHttpClient)
        {
            _httpClient = hHRuHttpClient;
        }

        public virtual async Task<GetManagersResponse> GetResponse()
        {
            return null;
        }
    }
}
