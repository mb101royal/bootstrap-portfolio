namespace bootstrap_portfolio.Business.Helpers
{
    public static class CommonHelpers
    {
        // Id checker
        public static bool CheckId(this int? id)
        {
            bool result = true;

            if (id < 1 || id == null) return false;

            return result;
        }
    }
}
