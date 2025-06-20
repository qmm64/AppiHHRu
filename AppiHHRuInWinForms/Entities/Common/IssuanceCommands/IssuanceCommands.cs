using AppiHHRuInWinForms.Entities.Common.Responses;

namespace AppiHHRuInWinForms.Entities.Common.IssuanceCommands
{
    public abstract class IssuanceCommands
    {
        protected ExtraditionManager extraditionManager;
        public virtual string Description()
        {
            return "";
        }

        public virtual async Task<List<string>> Execute()
        {
            return null;
        }

        public override string ToString()
        {
            return Description();
        }
    }
}
