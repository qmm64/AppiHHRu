
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
